using FirebirdSql.Data.FirebirdClient;
using SpreadsheetLight;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Reporte_de_Surtido
{
    public partial class Form1 : Form
    {
        private List<string> nombres = new() { };
        string Buscar_Folio;
        string oficial_surtidor;
        decimal oficial_importe = 0;
        string oficial_id;
        int oficial_contador;
        private bool isDragging = false;
        private Point dragStart;
        string Inicio;
        TimeSpan diferencia;
        public Form1()
        {
            InitializeComponent();
            Leer_Datos();
            Cb_Surtidor.SelectedIndex = -1;

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
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (TxtFolio.Text != string.Empty && Cb_Surtidor.Text != string.Empty)
            {
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
                            return;
                        }
                        reader0.Close();
                        /*
                        string query = "SELECT * FROM DOCTOS_VE_DET ORDER BY DOCTO_VE_ID DESC";
                        //string query = "SELECT * FROM DOCTOS_VE_DET ORDER BY DOCTO_VE_ID DESC";
                        FbCommand command = new FbCommand(query, con);
                        // Objeto para leer los datos obtenidos
                        FbDataReader reader = command.ExecuteReader();
                        encontrado = false;
                        while (reader.Read())
                        {
                            string columnaid = reader.GetString(1);
                            if (columnaid == oficial_id)
                            {
                                MessageBox.Show("encontrado");
                                while (columnaid == oficial_id)
                                {
                                    oficial_contador = oficial_contador + 1;
                                    //MessageBox.Show(oficial_contador.ToString());
                                    // Mover al siguiente registro
                                    if (!reader.Read())
                                    {
                                        MessageBox.Show("no encontrado");
                                        break; // Salir del bucle si no hay más registros
                                    }
                                    columnaid = reader.GetString(1); // Actualizar el valor de columnaid
                                }
                            MessageBox.Show(oficial_contador.ToString());
                            break;
                            }
                        }
                        MessageBox.Show("No encontrado");
                        reader.Close();
                        */
                        Excel();
                        // Obtén acceso a la colección de filas del control Data_Kardex
                        DataGridViewRowCollection rows = Data_Kardex.Rows;

                        // Agrega una nueva fila y especifica los valores de las celdas
                        rows.Add(TxtFolio.Text, oficial_surtidor, oficial_importe, Inicio);

                        TxtFolio.Text = string.Empty;
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
            }
        }
        public void Excel()
        {
            string path = "C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx";
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                SLDocument sl = new("C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx", "Sheet1");
                int i = 1;
                Inicio = DateTime.Now.ToLongTimeString();
                while (sl.HasCellValue("A" + i))
                {
                    i++;
                }
                int[] columnas = { 1, 2, 3, 4, 5, 6, 7 };
                foreach (int columna in columnas)
                {
                    sl.SetColumnWidth(columna, 30);
                }
                sl.SetCellValue("A" + i, i - 1);
                sl.SetCellValue("B" + i, TxtFolio.Text);
                sl.SetCellValue("C" + i, Cb_Surtidor.Text);
                sl.SetCellValue("D" + i, Inicio);
                sl.SetCellValue("E" + i, oficial_importe);
                sl.SaveAs("C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx");
            }
            else if (!fileExist)
            {
                Inicio = DateTime.Now.ToLongTimeString();
                SLDocument oSLDocument = new();
                DataTable table = new();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Folio", typeof(string));
                table.Columns.Add("Surtidor", typeof(string));
                table.Columns.Add("Hora Inicio", typeof(string));
                table.Columns.Add("Importe", typeof(decimal));
                table.Columns.Add("Hora Fin", typeof(string));
                table.Columns.Add("Duracion", typeof(string));
                table.Rows.Add(1, TxtFolio.Text, Cb_Surtidor.Text, Inicio, oficial_importe, "", "");
                oSLDocument.ImportDataTable(1, 1, table, true);
                oSLDocument.SaveAs("C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx");
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
                string path = "C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx";
                bool fileExist = File.Exists(path);
                if (fileExist)
                {
                    bool encontrado = false;
                    SLDocument sl = new("C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx", "Sheet1");
                    int i = 1;
                    while (sl.HasCellValue("B" + i))
                    {
                        if (TxtFolio2.Text == sl.GetCellValueAsString("B" + i))
                        {
                            encontrado = true;
                            sl.SetCellValue("F" + i, DateTime.Now.ToLongTimeString());
                            string inicioStr = sl.GetCellValueAsString("D" + i); // Obtener el valor de la celda como cadena
                            string finStr = sl.GetCellValueAsString("F" + i); // Obtener el valor de la celda como cadena
                            DateTime inicio;
                            DateTime fin;
                            if (DateTime.TryParse(inicioStr, out inicio) && DateTime.TryParse(finStr, out fin))
                            {
                                diferencia = fin - inicio;
                                sl.SetCellValue("G" + i, diferencia.ToString());
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
                            MessageBox.Show("Terminado con exito! \n"+"Tiempo transcurrido: "+diferencia.ToString());
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
                    sl.SaveAs("C:\\Datos_Surtido\\Registro de Surtidores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx");
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
    }
}