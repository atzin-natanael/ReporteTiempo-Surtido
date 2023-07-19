using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using FirebirdSql.Data.FirebirdClient;
using SpreadsheetLight;
using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace Reporte_de_Surtido
{
    public partial class Form1 : Form
    {
        DateTime fechaActual = DateTime.Now;
        private List<string> nombres = new() { };
        string Buscar_Folio;
        string oficial_surtidor;
        decimal oficial_importe = 0;
        decimal current_importe = 0;
        string oficial_id;
        string current_surtidor;
        string current_tiempo;
        int current_renglones;
        int oficial_contador;
        private bool isDragging = false;
        private Point dragStart;
        string Inicio;
        TimeSpan diferencia;
        DateTime suma;
        string path;
        int Num_renglones;
        public Form1()
        {
            InitializeComponent();
            CrearExcel();
            Leer_Datos();
            TxtFolio.Select();
            Cb_Surtidor.SelectedIndex = -1;

        }
        public void CrearExcel()
        {
            DateTime actual = DateTime.Now;
            if (actual.DayOfWeek.ToString() == "Thursday")
            {
                path = "C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + " a" + actual.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
            }
            else
            {
                int contador = 0;
                int valor_dia = (int)actual.DayOfWeek;
                for (; valor_dia >= 0; --valor_dia)
                {
                    contador++;
                    if (valor_dia <= 3 && valor_dia == 0)
                    {
                        contador += 2;
                        DateTime pasada = fechaActual.AddDays(-contador);
                        path = "C:\\Datos_Surtido\\Registro de Surtidores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                        break;
                    }
                    if (valor_dia > 4)
                    {
                        if (valor_dia == 5)
                        {
                            DateTime pasada = fechaActual.AddDays(-contador);
                            path = "C:\\Datos_Surtido\\Registro de Surtidores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                            break;
                        }
                        if (valor_dia == 6)
                        {
                            contador += 1;
                            DateTime pasada = fechaActual.AddDays(-contador);
                            path = "C:\\Datos_Surtido\\Registro de Surtidores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                            break;
                        }
                        if (valor_dia == 7)
                        {
                            contador += 2;
                            DateTime pasada = fechaActual.AddDays(-contador);
                            path = "C:\\Datos_Surtido\\Registro de Surtidores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                            break;
                        }
                    }
                }
            }
        }
        public void Leer_Datos()
        {
            string filePath = "C:\\Datos_Surtido\\Claves.txt";

            // Leer el contenido del archivo y asignarlo a una matriz de cadenas
            string[] nombresArray = File.ReadAllLines(filePath);
            nombres = new List<string>(nombresArray);
            Cb_Surtidor.DataSource = nombres;
            Cb_Surtidor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cb_Surtidor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cb_Surtidor.AutoCompleteCustomSource.AddRange(nombres.ToArray());
            Cb_Surtidor.Text = "";
        }
        void Promedio()
        {
            //string rutaArchivo = "C:\\Datos_Surtido\\Registro de Surtidores" + diaSemana + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx";
            SLDocument sl = new SLDocument(path);
            // Agregar una nueva hoja
            sl.AddWorksheet("Promedio");
            sl.SelectWorksheet("Promedio");
            int[] columnas = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int columna in columnas)
            {
                sl.SetColumnWidth(columna, 30);
            }
            sl.SetCellValue("A1", "SURTIDOR");
            sl.SetCellValue("B1", "PEDIDOS SURTIDOS");
            sl.SetCellValue("C1", "IMPORTE GENERADO");
            sl.SetCellValue("D1", "PORCENTAJE DE IMPORTE");
            sl.SetCellValue("E1", "MINUTOS EN SURTIR");
            sl.SetCellValue("F1", "RENGLONES SURTIDOS");
            sl.SetCellValue("G1", "IMPORTE TOTAL");
            int i = 2;
            int j = 2;
            bool Encontrar = false;
            while (sl.HasCellValue("A" + i))
            {
                if (sl.GetCellValueAsString(i, 1) == current_surtidor)
                {
                    Encontrar = true;
                    decimal imp = sl.GetCellValueAsDecimal("C" + i);
                    decimal total = sl.GetCellValueAsDecimal("G2");
                    DateTime tiempo_generado = sl.GetCellValueAsDateTime("E" + i);
                    int pedidos = sl.GetCellValueAsInt32("B" + i);
                    int renglones = sl.GetCellValueAsInt32("F" + i);
                    sl.SetCellValue("C" + i, current_importe + imp);
                    sl.SetCellValue("G" + 2, current_importe + total);
                    sl.SetCellValue("B" + i, pedidos + 1);
                    sl.SetCellValue("F" + i, current_renglones + renglones);
                    total = sl.GetCellValueAsDecimal("G2");
                    double tiempo = sl.GetCellValueAsDouble("E" + i);
                    double tot = tiempo + diferencia.TotalMinutes;

                    sl.SetCellValue("E" + i, tot);
                    while (sl.HasCellValue("C" + j))
                    {
                        decimal temp_importe = sl.GetCellValueAsDecimal("C" + j);
                        sl.SetCellValue("D" + j, 100 * (temp_importe / total));
                        j++;
                    }
                }
                i++;
            }
            if (Encontrar == false)
            {
                decimal total = sl.GetCellValueAsDecimal("G2");
                sl.SetCellValue("A" + i, current_surtidor);
                decimal imp = sl.GetCellValueAsDecimal("C" + i);
                sl.SetCellValue("C" + i, current_importe);
                double tiempo = sl.GetCellValueAsDouble("E" + i);
                double tot = tiempo + diferencia.TotalMinutes;
                sl.SetCellValue("E" + i, tot);
                int renglones = sl.GetCellValueAsInt32("F" + i);
                sl.SetCellValue("F" + i, current_renglones + renglones);
                sl.SetCellValue("G" + 2, current_importe + total);
                total = sl.GetCellValueAsDecimal("G2");
                int pedidos = sl.GetCellValueAsInt32("B" + i);
                sl.SetCellValue("B" + i, pedidos + 1);
                while (sl.HasCellValue("C" + j))
                {
                    decimal temp_importe = sl.GetCellValueAsDecimal("C" + j);
                    sl.SetCellValue("D" + j, 100 * (temp_importe / total));
                    j++;

                }
            }
            SLSheetProtection sp = new SLSheetProtection();
            sp.AllowInsertRows = true;
            sp.AllowInsertColumns = false;
            sp.AllowFormatCells = true;
            sp.AllowDeleteColumns = true;
            sl.ProtectWorksheet(sp);
            // Guardar el archivo con la nueva hoja agregada
            sl.SaveAs(path);

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (TxtFolio.Text != string.Empty && Cb_Surtidor.Text != string.Empty)
            {
                bool fileExist = File.Exists(path);
                if (fileExist)
                {
                    SLDocument sl = new(path);
                    sl.SelectWorksheet("Reporte Surtido");
                    int i = 1;
                    Inicio = DateTime.Now.ToLongTimeString();
                    while (sl.HasCellValue("B" + i))
                    {
                        if (sl.GetCellValueAsString("B" + i) == TxtFolio.Text)
                        {
                            MessageBox.Show("Ese pedido ya está iniciado o terminado", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtFolio.Text = string.Empty;
                            Cb_Surtidor.Text = "";
                            TxtFolio.Focus();
                            return;
                        }
                        i++;
                    }
                }
                FbConnection con = new FbConnection("User=SYSDBA;" + "Password=C0r1b423;" + "Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;" + "DataSource=192.168.0.11;" + "Port=3050;" + "Dialect=3;" + "Charset=UTF8;");
                try
                {
                    Buscar_Folio = TxtFolio.Text;
                    con.Open();
                    if ((Buscar_Folio[0] is 'P' && Buscar_Folio[1] is 'O') || (Buscar_Folio[0] is 'P' && Buscar_Folio[1] is 'E') || (Buscar_Folio[0] is 'P'))
                    {
                        string query0 = "SELECT * FROM DOCTOS_VE WHERE (FOLIO LIKE 'P%') AND TIPO_DOCTO = 'P' AND ESTATUS = 'P' ORDER BY FECHA DESC";
                        FbCommand command0 = new FbCommand(query0, con);
                        // Objeto para leer los datos obtenidos
                        FbDataReader reader0 = command0.ExecuteReader();
                        bool encontrado = false;
                        oficial_surtidor = Cb_Surtidor.Text;
                        // Iterar sobre los registros y mostrar los valores
                        if (Buscar_Folio[1] == 'O' || Buscar_Folio[1] == 'E')
                        {
                            int cont = 9 - Buscar_Folio.Length;
                            string prefix = Buscar_Folio.Substring(0, 2);
                            string suffix = Buscar_Folio.Substring(2);
                            string patch = "";
                            for (int i = 0; i < cont; i++)
                            {
                                patch = patch + "0";
                            }
                            Buscar_Folio = prefix + patch + suffix;
                        }
                        else if (Buscar_Folio[0] == 'P')
                        {
                            int cont = 9 - Buscar_Folio.Length;
                            string prefix = Buscar_Folio.Substring(0, 1);
                            string suffix = Buscar_Folio.Substring(1);
                            string patch = "";
                            for (int i = 0; i < cont; i++)
                            {
                                patch = patch + "0";
                            }
                            Buscar_Folio = prefix + patch + suffix;
                        }
                        while (reader0.Read())
                        {
                            // Acceder a los valores de cada columna por su índice o nombre
                            string columnaid = reader0.GetString(0);
                            string columnafolio = reader0.GetString(4);
                            decimal importe = reader0.GetDecimal(26);
                            if (columnafolio == Buscar_Folio)
                            {
                                oficial_id = columnaid;
                                oficial_importe = importe;
                                encontrado = true;
                                break;
                            }
                        }
                        if (encontrado == false)
                        {
                            MessageBox.Show("FOLIO NO ENCONTRADO", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtFolio.Focus();
                            return;
                        }
                        reader0.Close();
                        FbCommand command = new FbCommand("CALC_TOTALES_DOCTO_VE", con);
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro V_DOCTO_VE_ID
                        FbParameter paramV_DOCTO_VE_ID = new FbParameter("V_DOCTO_VE_ID", FbDbType.Integer);
                        paramV_DOCTO_VE_ID.Value = oficial_id;
                        command.Parameters.Add(paramV_DOCTO_VE_ID);

                        // Parámetro V_SOLO_LECTURA
                        FbParameter paramV_SOLO_LECTURA = new FbParameter("V_SOLO_LECTURA", FbDbType.Char);
                        paramV_SOLO_LECTURA.Size = 1;
                        paramV_SOLO_LECTURA.Value = 'S';
                        command.Parameters.Add(paramV_SOLO_LECTURA);

                        // Parámetro de retorno NUM_RENGLONES
                        FbParameter paramNUM_RENGLONES = new FbParameter();
                        paramNUM_RENGLONES.ParameterName = "NUM_RENGLONES";
                        paramNUM_RENGLONES.Direction = ParameterDirection.Output;
                        paramNUM_RENGLONES.FbDbType = FbDbType.Integer;
                        command.Parameters.Add(paramNUM_RENGLONES);

                        // Ejecutar el procedimiento almacenado
                        command.ExecuteNonQuery();

                        // Obtener el valor de retorno NUM_RENGLONES
                        Num_renglones = (int)paramNUM_RENGLONES.Value;
                        Excel();
                        // Obtén acceso a la colección de filas del control Data_Kardex
                        DataGridViewRowCollection rows = Data_Kardex.Rows;

                        // Agrega una nueva fila y especifica los valores de las celdas
                        rows.Add(TxtFolio.Text, oficial_surtidor, Inicio, oficial_importe, Num_renglones);

                        TxtFolio.Text = string.Empty;
                        if (!Check_mantener.Checked)
                            Cb_Surtidor.Text = string.Empty;
                        TxtFolio.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtFolio.Focus();
            }
        }
        public void Excel()
        {
            // string path = "C:\\Datos_Surtido\\Registro de Surtidores" + diaSemana + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx";
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                SLDocument sl = new(path);
                sl.SelectWorksheet("Reporte Surtido");
                int i = 1;
                Inicio = DateTime.Now.ToLongTimeString();
                while (sl.HasCellValue("A" + i))
                {
                    i++;
                }
                int[] columnas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                foreach (int columna in columnas)
                {
                    sl.SetColumnWidth(columna, 30);
                }
                sl.SetCellValue("A" + i, i - 1);
                sl.SetCellValue("B" + i, TxtFolio.Text);
                sl.SetCellValue("C" + i, Cb_Surtidor.Text);
                sl.SetCellValue("D" + i, Inicio);
                sl.SetCellValue("E" + i, oficial_importe);
                sl.SetCellValue("H" + i, Num_renglones);
                sl.SetCellValue("I" + i, DateTime.Now.ToString(" yyyy-MM-dd"));
                sl.SaveAs(path);

            }
            else if (!fileExist)
            {
                Inicio = DateTime.Now.ToLongTimeString();
                SLDocument oSLDocument = new();
                string actual = oSLDocument.GetCurrentWorksheetName();
                oSLDocument.RenameWorksheet(actual, "Reporte Surtido");
                DataTable table = new();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Folio", typeof(string));
                table.Columns.Add("Surtidor", typeof(string));
                table.Columns.Add("Hora Inicio", typeof(string));
                table.Columns.Add("Importe", typeof(decimal));
                table.Columns.Add("Hora Fin", typeof(string));
                table.Columns.Add("Duracion", typeof(string));
                table.Columns.Add("Renglones", typeof(int));
                table.Columns.Add("Fecha", typeof(string));
                table.Rows.Add(1, TxtFolio.Text, Cb_Surtidor.Text, Inicio, oficial_importe, "", "", Num_renglones, DateTime.Now.ToString(" yyyy-MM-dd"));
                oSLDocument.ImportDataTable(1, 1, table, true);
                oSLDocument.SaveAs(path);
            }
        }

        private void TxtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Cb_Surtidor.Focus();
            }
        }

        private void Cb_Surtidor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnIniciar.Focus();
            }
        }

        private void TxtFolio2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnTerminar.Focus();
            }

        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            if (TxtFolio2.Text != string.Empty)
            {
                //string path = "C:\\Datos_Surtido\\Registro de Surtidores" + diaSemana + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx";
                bool fileExist = File.Exists(path);
                if (fileExist)
                {
                    bool encontrado = false;
                    SLDocument sl = new(path);
                    sl.SelectWorksheet("Reporte Surtido");
                    int i = 1;
                    while (sl.HasCellValue("B" + i))
                    {
                        if (TxtFolio2.Text == sl.GetCellValueAsString("B" + i))
                        {
                            if (sl.GetCellValueAsString("F" + i) != string.Empty)
                            {
                                MessageBox.Show("Ese pedido ya está Terminado", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                TxtFolio2.Text = string.Empty;
                                TxtFolio2.Focus();
                                return;
                            }
                            encontrado = true;
                            sl.SetCellValue("F" + i, DateTime.Now.ToLongTimeString());
                            current_importe = sl.GetCellValueAsDecimal(i, 5);
                            current_surtidor = sl.GetCellValueAsString(i, 3);
                            current_renglones = sl.GetCellValueAsInt32(i, 8);
                            string inicioStr = sl.GetCellValueAsString("D" + i); // Obtener el valor de la celda como cadena
                            string finStr = sl.GetCellValueAsString("F" + i); // Obtener el valor de la celda como cadena
                            DateTime inicio;
                            DateTime fin;
                            if (DateTime.TryParse(inicioStr, out inicio) && DateTime.TryParse(finStr, out fin))
                            {
                                diferencia = fin - inicio;
                                sl.SetCellValue("G" + i, diferencia.ToString());
                                current_tiempo = sl.GetCellValueAsString(i, 7);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo convertir los valores de las celdas a DateTime.");
                            }
                            foreach (DataGridViewRow fila in Data_Kardex.Rows)
                            {
                                // Compara el valor de la columna deseada con el parámetro
                                if (fila.Cells["Folio"].Value.ToString() == TxtFolio2.Text)
                                {
                                    // Elimina la fila encontrada utilizando el índice de la fila
                                    Data_Kardex.Rows.RemoveAt(fila.Index);
                                    break; // Termina el bucle una vez que se haya eliminado la fila deseada
                                }
                            }
                            MessageBox.Show("Terminado con exito! \n" + "Tiempo transcurrido: " + diferencia.ToString());
                            TxtFolio2.Text = string.Empty;
                            TxtFolio2.Focus();
                            break;
                        }
                        i++;
                    }
                    if (encontrado == false)
                    {
                        MessageBox.Show("No se ha encontrado ese pedido iniciado", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int[] columnas = { 1, 2, 3, 4, 5, 6 };
                    foreach (int columna in columnas)
                    {
                        sl.SetColumnWidth(columna, 30);
                    }
                    sl.SaveAs(path);
                    Promedio();
                }
                else if (!fileExist)
                {
                    MessageBox.Show("Aún no has registrado un surtidor", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtFolio2.Text = string.Empty;
                    TxtFolio2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtFolio2.Focus();
            }

        }

        private void Pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FlowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStart = e.Location;
            }
        }

        private void FlowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - dragStart.X;
                int deltaY = e.Y - dragStart.Y;

                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void FlowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // string path = "C:\\Datos_Surtido\\Registro de Surtidores" + diaSemana + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx";
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                SLDocument sl = new(path);
                sl.SelectWorksheet("Reporte Surtido");
                // Obtener los datos de la hoja de cálculo en un arreglo bidimensional
                int numFilas = sl.GetWorksheetStatistics().NumberOfRows;

                DataGridViewRowCollection rows = Data_Kardex.Rows;

                // Agrega una nueva fila y especifica los valores de las celdas
                for (int i = 2; i <= numFilas; i++)
                {
                    if (sl.GetCellValueAsString(i, 6) == string.Empty)
                    {
                        rows.Add(sl.GetCellValueAsString(i, 2), sl.GetCellValueAsString(i, 3), sl.GetCellValueAsString(i, 4), sl.GetCellValueAsDecimal(i, 5), sl.GetCellValueAsInt32(i, 8));
                    }
                }
            }
        }

        private void Check_mantener_CheckedChanged(object sender, EventArgs e)
        {
            if (!Check_mantener.Checked)
            {
                Cb_Surtidor.Text = "";
            }
        }

        private void TabIniciar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPage1.Focus())
            {
                tabPage1.Controls.Add(Data_Kardex);
                TxtFolio.Focus();
            }
            if (tabPage2.Focus())
            {
                tabPage2.Controls.Add(Data_Kardex);
                TxtFolio2.Focus();
            }
        }

        private void Cb_Surtidor_Leave(object sender, EventArgs e)
        {
            if (!nombres.Contains(Cb_Surtidor.Text) && Cb_Surtidor.Text != "")
            {
                MessageBox.Show("Ese surtidor no está registrado", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cb_Surtidor.Text = "";
                Cb_Surtidor.Focus();
            }
        }

        private void Cb_Surtidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void Pb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Max_Click(object sender, EventArgs e)
        {
            // Si la ventana está maximizada, restaurarla a su estado normal
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else // Si la ventana no está maximizada, maximizarla
            {
                this.WindowState = FormWindowState.Maximized;
                Data_Kardex.Columns["Surtidor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                Data_Kardex.Columns["Folio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                Data_Kardex.Columns["Importe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                Data_Kardex.Columns["Renglones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            }
        }
    }
}