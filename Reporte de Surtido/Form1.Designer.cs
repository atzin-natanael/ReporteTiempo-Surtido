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
            Btn_Max = new PictureBox();
            Pb_Min = new PictureBox();
            label1 = new Label();
            TabIniciar = new TabControl();
            tabPage1 = new TabPage();
            Check_mantener = new CheckBox();
            Data_Kardex = new DataGridView();
            Folio = new DataGridViewTextBoxColumn();
            Surtidor = new DataGridViewTextBoxColumn();
            HoraInicio = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            Renglones = new DataGridViewTextBoxColumn();
            BtnIniciar = new Button();
            TxtFolio = new TextBox();
            pictureBox1 = new PictureBox();
            Cb_Surtidor = new ComboBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            BtnTerminar = new Button();
            TxtFolio2 = new TextBox();
            FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Min).BeginInit();
            TabIniciar.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Kardex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FlowLayoutPanel1.BackColor = Color.SteelBlue;
            FlowLayoutPanel1.Controls.Add(Pb_Cerrar);
            FlowLayoutPanel1.Controls.Add(Btn_Max);
            FlowLayoutPanel1.Controls.Add(Pb_Min);
            FlowLayoutPanel1.Cursor = Cursors.SizeAll;
            FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            FlowLayoutPanel1.Location = new Point(-3, -2);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1012, 44);
            FlowLayoutPanel1.TabIndex = 0;
            FlowLayoutPanel1.MouseDown += FlowLayoutPanel1_MouseDown;
            FlowLayoutPanel1.MouseMove += FlowLayoutPanel1_MouseMove;
            FlowLayoutPanel1.MouseUp += FlowLayoutPanel1_MouseUp;
            // 
            // Pb_Cerrar
            // 
            Pb_Cerrar.Anchor = AnchorStyles.Top;
            Pb_Cerrar.BackColor = Color.SteelBlue;
            Pb_Cerrar.Cursor = Cursors.Hand;
            Pb_Cerrar.Image = (Image)resources.GetObject("Pb_Cerrar.Image");
            Pb_Cerrar.Location = new Point(962, 3);
            Pb_Cerrar.Name = "Pb_Cerrar";
            Pb_Cerrar.Size = new Size(47, 31);
            Pb_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Cerrar.TabIndex = 0;
            Pb_Cerrar.TabStop = false;
            Pb_Cerrar.Click += Pb_Cerrar_Click;
            Pb_Cerrar.MouseEnter += Pb_Cerrar_MouseEnter;
            Pb_Cerrar.MouseLeave += Pb_Cerrar_MouseLeave;
            // 
            // Btn_Max
            // 
            Btn_Max.Anchor = AnchorStyles.Top;
            Btn_Max.BackColor = Color.SteelBlue;
            Btn_Max.Cursor = Cursors.Hand;
            Btn_Max.Image = (Image)resources.GetObject("Btn_Max.Image");
            Btn_Max.Location = new Point(923, 3);
            Btn_Max.Name = "Btn_Max";
            Btn_Max.Size = new Size(33, 31);
            Btn_Max.SizeMode = PictureBoxSizeMode.StretchImage;
            Btn_Max.TabIndex = 15;
            Btn_Max.TabStop = false;
            Btn_Max.Click += Btn_Max_Click;
            // 
            // Pb_Min
            // 
            Pb_Min.Anchor = AnchorStyles.Top;
            Pb_Min.BackColor = Color.SteelBlue;
            Pb_Min.Cursor = Cursors.Hand;
            Pb_Min.Image = (Image)resources.GetObject("Pb_Min.Image");
            Pb_Min.Location = new Point(884, 3);
            Pb_Min.Name = "Pb_Min";
            Pb_Min.Size = new Size(33, 31);
            Pb_Min.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Min.TabIndex = 1;
            Pb_Min.TabStop = false;
            Pb_Min.Click += Pb_Min_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SPIDER-MAN:ECLIPSE", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 617);
            label1.Name = "label1";
            label1.Size = new Size(307, 20);
            label1.TabIndex = 1;
            label1.Text = "Developed by Atzin Not Found";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TabIniciar
            // 
            TabIniciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabIniciar.Controls.Add(tabPage1);
            TabIniciar.Controls.Add(tabPage2);
            TabIniciar.Location = new Point(12, 48);
            TabIniciar.Name = "TabIniciar";
            TabIniciar.SelectedIndex = 0;
            TabIniciar.Size = new Size(984, 669);
            TabIniciar.SizeMode = TabSizeMode.Fixed;
            TabIniciar.TabIndex = 1;
            TabIniciar.SelectedIndexChanged += TabIniciar_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DimGray;
            tabPage1.Controls.Add(Check_mantener);
            tabPage1.Controls.Add(Data_Kardex);
            tabPage1.Controls.Add(BtnIniciar);
            tabPage1.Controls.Add(TxtFolio);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Cb_Surtidor);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 641);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Iniciar";
            // 
            // Check_mantener
            // 
            Check_mantener.Anchor = AnchorStyles.Top;
            Check_mantener.AutoSize = true;
            Check_mantener.Location = new Point(280, 140);
            Check_mantener.Name = "Check_mantener";
            Check_mantener.Size = new Size(290, 22);
            Check_mantener.TabIndex = 14;
            Check_mantener.Text = "Mantener nombre del surtidor";
            Check_mantener.UseVisualStyleBackColor = true;
            Check_mantener.CheckedChanged += Check_mantener_CheckedChanged;
            // 
            // Data_Kardex
            // 
            Data_Kardex.AllowUserToAddRows = false;
            Data_Kardex.AllowUserToDeleteRows = false;
            Data_Kardex.AllowUserToOrderColumns = true;
            Data_Kardex.AllowUserToResizeColumns = false;
            Data_Kardex.AllowUserToResizeRows = false;
            Data_Kardex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Data_Kardex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_Kardex.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Data_Kardex.BackgroundColor = Color.DimGray;
            Data_Kardex.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            Data_Kardex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Kardex.Columns.AddRange(new DataGridViewColumn[] { Folio, Surtidor, HoraInicio, Importe, Renglones });
            Data_Kardex.EditMode = DataGridViewEditMode.EditProgrammatically;
            Data_Kardex.EnableHeadersVisualStyles = false;
            Data_Kardex.GridColor = Color.Blue;
            Data_Kardex.Location = new Point(38, 257);
            Data_Kardex.Name = "Data_Kardex";
            Data_Kardex.ReadOnly = true;
            Data_Kardex.RowHeadersVisible = false;
            Data_Kardex.RowTemplate.Height = 25;
            Data_Kardex.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Data_Kardex.Size = new Size(888, 347);
            Data_Kardex.TabIndex = 0;
            Data_Kardex.TabStop = false;
            // 
            // Folio
            // 
            Folio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Folio.HeaderText = "Folio";
            Folio.Name = "Folio";
            Folio.ReadOnly = true;
            Folio.Width = 120;
            // 
            // Surtidor
            // 
            Surtidor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Surtidor.HeaderText = "Surtidor";
            Surtidor.Name = "Surtidor";
            Surtidor.ReadOnly = true;
            Surtidor.Width = 320;
            // 
            // HoraInicio
            // 
            HoraInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HoraInicio.HeaderText = "Hora de Inicio";
            HoraInicio.Name = "HoraInicio";
            HoraInicio.ReadOnly = true;
            HoraInicio.Width = 180;
            // 
            // Importe
            // 
            Importe.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Importe.HeaderText = "Importe";
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            Importe.Width = 150;
            // 
            // Renglones
            // 
            Renglones.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Renglones.HeaderText = "Renglones";
            Renglones.Name = "Renglones";
            Renglones.ReadOnly = true;
            Renglones.Width = 115;
            // 
            // BtnIniciar
            // 
            BtnIniciar.Anchor = AnchorStyles.Top;
            BtnIniciar.BackColor = Color.ForestGreen;
            BtnIniciar.Cursor = Cursors.Hand;
            BtnIniciar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnIniciar.ForeColor = Color.Black;
            BtnIniciar.Location = new Point(762, 156);
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
            pictureBox1.Location = new Point(265, 6);
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
            Cb_Surtidor.KeyPress += Cb_Surtidor_KeyPress;
            Cb_Surtidor.Leave += Cb_Surtidor_Leave;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(label2);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SPIDER-MAN:ECLIPSE", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(663, 618);
            label2.Name = "label2";
            label2.Size = new Size(307, 20);
            label2.TabIndex = 18;
            label2.Text = "Developed by Atzin Not Found";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(265, 6);
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
            BtnTerminar.Location = new Point(556, 134);
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
            TxtFolio2.Location = new Point(294, 166);
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
            Controls.Add(TabIniciar);
            Controls.Add(FlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            FlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Max).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Min).EndInit();
            TabIniciar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Kardex).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private TabControl TabIniciar;
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
        private Label label2;
        private CheckBox Check_mantener;
        private PictureBox Pb_Min;
        private PictureBox Btn_Max;
        private DataGridViewTextBoxColumn Folio;
        private DataGridViewTextBoxColumn Surtidor;
        private DataGridViewTextBoxColumn HoraInicio;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn Renglones;
    }
}