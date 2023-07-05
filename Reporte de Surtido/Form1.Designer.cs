namespace Reporte_de_Surtido
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Pb_Cerrar = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Data_Kardex = new DataGridView();
            Folio = new DataGridViewTextBoxColumn();
            Surtidor = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            HoraInicio = new DataGridViewTextBoxColumn();
            BtnIniciar = new Button();
            TxtFolio = new TextBox();
            pictureBox1 = new PictureBox();
            Cb_Surtidor = new ComboBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            BtnTerminar = new Button();
            TxtFolio2 = new TextBox();
            FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_Cerrar).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Kardex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top;
            FlowLayoutPanel1.BackColor = Color.Black;
            FlowLayoutPanel1.Controls.Add(Pb_Cerrar);
            FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            FlowLayoutPanel1.Location = new Point(-3, 1);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1012, 41);
            FlowLayoutPanel1.TabIndex = 0;
            FlowLayoutPanel1.MouseDown += FlowLayoutPanel1_MouseDown;
            FlowLayoutPanel1.MouseMove += FlowLayoutPanel1_MouseMove;
            FlowLayoutPanel1.MouseUp += FlowLayoutPanel1_MouseUp;
            // 
            // Pb_Cerrar
            // 
            Pb_Cerrar.Anchor = AnchorStyles.Top;
            Pb_Cerrar.BackColor = Color.DimGray;
            Pb_Cerrar.Cursor = Cursors.Hand;
            Pb_Cerrar.Image = (Image)resources.GetObject("Pb_Cerrar.Image");
            Pb_Cerrar.Location = new Point(962, 3);
            Pb_Cerrar.Name = "Pb_Cerrar";
            Pb_Cerrar.Size = new Size(47, 31);
            Pb_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Cerrar.TabIndex = 0;
            Pb_Cerrar.TabStop = false;
            Pb_Cerrar.Click += Pb_Cerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Wildcard", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(333, 623);
            label1.Name = "label1";
            label1.Size = new Size(329, 15);
            label1.TabIndex = 1;
            label1.Text = "Developed by Atzin Not Found";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 669);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DimGray;
            tabPage1.Controls.Add(Data_Kardex);
            tabPage1.Controls.Add(BtnIniciar);
            tabPage1.Controls.Add(TxtFolio);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Cb_Surtidor);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 641);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Iniciar";
            // 
            // Data_Kardex
            // 
            Data_Kardex.AllowUserToAddRows = false;
            Data_Kardex.AllowUserToDeleteRows = false;
            Data_Kardex.AllowUserToOrderColumns = true;
            Data_Kardex.Anchor = AnchorStyles.Top;
            Data_Kardex.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            Data_Kardex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Kardex.Columns.AddRange(new DataGridViewColumn[] { Folio, Surtidor, Importe, HoraInicio });
            Data_Kardex.EditMode = DataGridViewEditMode.EditProgrammatically;
            Data_Kardex.EnableHeadersVisualStyles = false;
            Data_Kardex.Location = new Point(38, 257);
            Data_Kardex.Name = "Data_Kardex";
            Data_Kardex.ReadOnly = true;
            Data_Kardex.RowHeadersVisible = false;
            Data_Kardex.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Data_Kardex.RowTemplate.Height = 25;
            Data_Kardex.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Data_Kardex.Size = new Size(904, 182);
            Data_Kardex.TabIndex = 0;
            Data_Kardex.TabStop = false;
            // 
            // Folio
            // 
            Folio.HeaderText = "Folio";
            Folio.Name = "Folio";
            Folio.ReadOnly = true;
            Folio.Width = 200;
            // 
            // Surtidor
            // 
            Surtidor.HeaderText = "Surtidor";
            Surtidor.Name = "Surtidor";
            Surtidor.ReadOnly = true;
            Surtidor.Width = 400;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            Importe.Width = 150;
            // 
            // HoraInicio
            // 
            HoraInicio.HeaderText = "Hora de Inicio";
            HoraInicio.Name = "HoraInicio";
            HoraInicio.ReadOnly = true;
            HoraInicio.Width = 150;
            // 
            // BtnIniciar
            // 
            BtnIniciar.Anchor = AnchorStyles.Top;
            BtnIniciar.BackColor = Color.ForestGreen;
            BtnIniciar.Cursor = Cursors.Hand;
            BtnIniciar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnIniciar.ForeColor = Color.Black;
            BtnIniciar.Location = new Point(758, 168);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(184, 68);
            BtnIniciar.TabIndex = 3;
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.UseVisualStyleBackColor = false;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // TxtFolio
            // 
            TxtFolio.Anchor = AnchorStyles.Top;
            TxtFolio.BackColor = Color.White;
            TxtFolio.CharacterCasing = CharacterCasing.Upper;
            TxtFolio.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtFolio.ForeColor = Color.Black;
            TxtFolio.Location = new Point(22, 166);
            TxtFolio.MaxLength = 9;
            TxtFolio.Multiline = true;
            TxtFolio.Name = "TxtFolio";
            TxtFolio.PlaceholderText = "FOLIO";
            TxtFolio.Size = new Size(200, 31);
            TxtFolio.TabIndex = 1;
            TxtFolio.TextAlign = HorizontalAlignment.Center;
            TxtFolio.KeyDown += TxtFolio_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(276, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Cb_Surtidor
            // 
            Cb_Surtidor.AllowDrop = true;
            Cb_Surtidor.Anchor = AnchorStyles.Top;
            Cb_Surtidor.BackColor = Color.White;
            Cb_Surtidor.FlatStyle = FlatStyle.Flat;
            Cb_Surtidor.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Surtidor.ForeColor = Color.Black;
            Cb_Surtidor.FormattingEnabled = true;
            Cb_Surtidor.ItemHeight = 23;
            Cb_Surtidor.Location = new Point(282, 168);
            Cb_Surtidor.MaxDropDownItems = 1;
            Cb_Surtidor.Name = "Cb_Surtidor";
            Cb_Surtidor.Size = new Size(439, 31);
            Cb_Surtidor.TabIndex = 2;
            Cb_Surtidor.KeyDown += Cb_Surtidor_KeyDown;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(BtnTerminar);
            tabPage2.Controls.Add(TxtFolio2);
            tabPage2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(976, 641);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Finalizar";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(279, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(445, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // BtnTerminar
            // 
            BtnTerminar.Anchor = AnchorStyles.Top;
            BtnTerminar.BackColor = Color.Crimson;
            BtnTerminar.Cursor = Cursors.Hand;
            BtnTerminar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTerminar.ForeColor = Color.Black;
            BtnTerminar.Location = new Point(571, 208);
            BtnTerminar.Name = "BtnTerminar";
            BtnTerminar.Size = new Size(184, 68);
            BtnTerminar.TabIndex = 16;
            BtnTerminar.Text = "Finalizar";
            BtnTerminar.UseVisualStyleBackColor = false;
            BtnTerminar.Click += BtnTerminar_Click;
            // 
            // TxtFolio2
            // 
            TxtFolio2.Anchor = AnchorStyles.Top;
            TxtFolio2.BackColor = Color.White;
            TxtFolio2.CharacterCasing = CharacterCasing.Upper;
            TxtFolio2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtFolio2.ForeColor = Color.Black;
            TxtFolio2.Location = new Point(257, 227);
            TxtFolio2.MaxLength = 9;
            TxtFolio2.Multiline = true;
            TxtFolio2.Name = "TxtFolio2";
            TxtFolio2.PlaceholderText = "FOLIO";
            TxtFolio2.Size = new Size(219, 36);
            TxtFolio2.TabIndex = 15;
            TxtFolio2.TextAlign = HorizontalAlignment.Center;
            TxtFolio2.KeyDown += TxtFolio2_KeyDown;
            // 
            // Form1
            // 
            BackColor = Color.DimGray;
            ClientSize = new Size(1008, 729);
            Controls.Add(tabControl1);
            Controls.Add(FlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            FlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_Cerrar).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Kardex).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox Pb_Cerrar;
        private PictureBox pictureBox2;
        private FlowLayoutPanel FlowLayoutPanel1;
        private ComboBox Cb_Surtidor;
        private Label label1;
        private Button BtnIniciar;
        private PictureBox pictureBox1;
        private TextBox TxtFolio;
        private DataGridView Data_Kardex;
        private Button BtnTerminar;
        private TextBox TxtFolio2;
        private DataGridViewTextBoxColumn Folio;
        private DataGridViewTextBoxColumn Surtidor;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn HoraInicio;
    }
}