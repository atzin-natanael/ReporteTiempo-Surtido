using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte_de_Surtido
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
            Txt_Numero.Select();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Txt_Numero.Text != string.Empty && Txt_Nombre.Text != string.Empty && Txt_Apellido.Text != string.Empty && Cb_Bandera.Text != string.Empty)
            {
                string filePath2 = "\\\\192.168.0.2\\C$\\clavesSurtido\\Claves.xlsx";
                using (SLDocument documento = new SLDocument(filePath2))
                {
                    int i = 1;
                    while (documento.HasCellValue("A" + i))
                    {
                        if (Txt_Numero.Text == documento.GetCellValueAsString("A" + i))
                        {
                            MessageBox.Show("Ese número ya existe", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Txt_Numero.Focus();
                            return;
                        }
                        i++;
                    }
                    int filas = (documento.GetWorksheetStatistics().NumberOfRows) + 1;
                    documento.SetCellValue("A" + filas, int.Parse(Txt_Numero.Text));
                    documento.SetCellValue("B" + filas, Txt_Apellido.Text + " " + Txt_Nombre.Text);
                    if (Cb_Bandera.Text == "SI")
                        documento.SetCellValue("C" + filas, "S");
                    else
                        documento.SetCellValue("C" + filas, "N");
                    documento.Save();
                }
                MessageBox.Show("Agregado con Éxito");
                Txt_Nombre.Text = string.Empty;
                Txt_Numero.Text = string.Empty;
                Txt_Apellido.Text = string.Empty;
                Cb_Bandera.SelectedIndex = -1;
                Txt_Numero.Focus();
                this.Close();
            }
            else
            {
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Numero.Focus();
            }
        }

        private void Txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Txt_Nombre.Focus();
            }
        }

        private void Txt_Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Txt_Apellido.Focus();
            }
        }

        private void Txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Txt_Apellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Cb_Bandera.Focus();
            }

        }

        private void Cb_Bandera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Btn_Agregar.Focus();
            }

        }

        private void Txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
