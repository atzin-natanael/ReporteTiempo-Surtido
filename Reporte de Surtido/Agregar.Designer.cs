namespace Reporte_de_Surtido
{
    partial class Agregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            label4 = new Label();
            Cb_Bandera = new ComboBox();
            label2 = new Label();
            Txt_Apellido = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Txt_Nombre = new TextBox();
            Txt_Numero = new TextBox();
            Btn_Agregar = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(496, 10);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 36;
            label4.Text = "Apellido";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cb_Bandera
            // 
            Cb_Bandera.DisplayMember = "1";
            Cb_Bandera.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Bandera.FlatStyle = FlatStyle.Flat;
            Cb_Bandera.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Bandera.FormattingEnabled = true;
            Cb_Bandera.Items.AddRange(new object[] { "SI", "NO" });
            Cb_Bandera.Location = new Point(727, 56);
            Cb_Bandera.Name = "Cb_Bandera";
            Cb_Bandera.Size = new Size(96, 33);
            Cb_Bandera.TabIndex = 31;
            Cb_Bandera.ValueMember = "1";
            Cb_Bandera.KeyDown += Cb_Bandera_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(669, 9);
            label2.Name = "label2";
            label2.Size = new Size(195, 16);
            label2.TabIndex = 35;
            label2.Text = "¿Eres del área de surtido?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Apellido
            // 
            Txt_Apellido.Anchor = AnchorStyles.Top;
            Txt_Apellido.BorderStyle = BorderStyle.FixedSingle;
            Txt_Apellido.CharacterCasing = CharacterCasing.Upper;
            Txt_Apellido.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Apellido.Location = new Point(397, 55);
            Txt_Apellido.Multiline = true;
            Txt_Apellido.Name = "Txt_Apellido";
            Txt_Apellido.PlaceholderText = "APELLIDO";
            Txt_Apellido.Size = new Size(229, 34);
            Txt_Apellido.TabIndex = 30;
            Txt_Apellido.TextAlign = HorizontalAlignment.Center;
            Txt_Apellido.KeyDown += Txt_Apellido_KeyDown;
            Txt_Apellido.KeyPress += Txt_Apellido_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(262, 10);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 34;
            label5.Text = "Nombre";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 10);
            label6.Name = "label6";
            label6.Size = new Size(162, 16);
            label6.TabIndex = 33;
            label6.Text = "Número de empleado";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.Anchor = AnchorStyles.Top;
            Txt_Nombre.BorderStyle = BorderStyle.FixedSingle;
            Txt_Nombre.CharacterCasing = CharacterCasing.Upper;
            Txt_Nombre.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Nombre.Location = new Point(188, 54);
            Txt_Nombre.Multiline = true;
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.PlaceholderText = "NOMBRE";
            Txt_Nombre.Size = new Size(203, 34);
            Txt_Nombre.TabIndex = 29;
            Txt_Nombre.TextAlign = HorizontalAlignment.Center;
            Txt_Nombre.KeyDown += Txt_Nombre_KeyDown;
            Txt_Nombre.KeyPress += Txt_Nombre_KeyPress;
            // 
            // Txt_Numero
            // 
            Txt_Numero.Anchor = AnchorStyles.Top;
            Txt_Numero.BorderStyle = BorderStyle.FixedSingle;
            Txt_Numero.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Numero.Location = new Point(19, 55);
            Txt_Numero.Multiline = true;
            Txt_Numero.Name = "Txt_Numero";
            Txt_Numero.PlaceholderText = "NÚMERO";
            Txt_Numero.Size = new Size(163, 34);
            Txt_Numero.TabIndex = 28;
            Txt_Numero.TextAlign = HorizontalAlignment.Center;
            Txt_Numero.KeyDown += Txt_Numero_KeyDown;
            Txt_Numero.KeyPress += Txt_Numero_KeyPress;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.Anchor = AnchorStyles.Top;
            Btn_Agregar.BackColor = Color.Green;
            Btn_Agregar.Cursor = Cursors.Hand;
            Btn_Agregar.FlatStyle = FlatStyle.Flat;
            Btn_Agregar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Agregar.Location = new Point(432, 116);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(139, 49);
            Btn_Agregar.TabIndex = 32;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = false;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(942, 186);
            Controls.Add(label4);
            Controls.Add(Cb_Bandera);
            Controls.Add(label2);
            Controls.Add(Txt_Apellido);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(Txt_Nombre);
            Controls.Add(Txt_Numero);
            Controls.Add(Btn_Agregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Agregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox Cb_Bandera;
        private Label label2;
        private TextBox Txt_Apellido;
        private Label label5;
        private Label label6;
        private TextBox Txt_Nombre;
        private TextBox Txt_Numero;
        private Button Btn_Agregar;
    }
}