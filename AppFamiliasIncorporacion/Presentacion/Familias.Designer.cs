namespace AppFamiliasIncorporacion.Presentacion
{
    partial class Familias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Familias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.bntExit = new System.Windows.Forms.Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gtxtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gdtgFamilias = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtApellidoMTutora = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtApellidoPTutora = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtFamiliaId = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtNombreTutora = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtFolioEncuesta = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtCurp = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtAvisoCobro = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdtgFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 12;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.bntExit);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(974, 44);
            this.gunaPanel1.TabIndex = 0;
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bntExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntExit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.bntExit.FlatAppearance.BorderSize = 0;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bntExit.ForeColor = System.Drawing.Color.Crimson;
            this.bntExit.Image = ((System.Drawing.Image)(resources.GetObject("bntExit.Image")));
            this.bntExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExit.Location = new System.Drawing.Point(899, 0);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 44);
            this.bntExit.TabIndex = 1;
            this.bntExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(13, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(177, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Familias Incorporadas";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Controls.Add(this.gtxtSearch);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 44);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1200, 67);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(595, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(62, 57);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gtxtSearch
            // 
            this.gtxtSearch.BaseColor = System.Drawing.Color.White;
            this.gtxtSearch.BorderColor = System.Drawing.Color.White;
            this.gtxtSearch.BorderSize = 1;
            this.gtxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtSearch.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtSearch.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtSearch.ForeColor = System.Drawing.Color.Gray;
            this.gtxtSearch.Location = new System.Drawing.Point(213, 11);
            this.gtxtSearch.Name = "gtxtSearch";
            this.gtxtSearch.PasswordChar = '\0';
            this.gtxtSearch.SelectedText = "";
            this.gtxtSearch.Size = new System.Drawing.Size(380, 44);
            this.gtxtSearch.TabIndex = 1;
            this.gtxtSearch.Text = "Ingresa Dato a Buscar";
            this.gtxtSearch.Click += new System.EventHandler(this.gunaTextBox1_Click);
            // 
            // gdtgFamilias
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdtgFamilias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdtgFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdtgFamilias.BackgroundColor = System.Drawing.Color.White;
            this.gdtgFamilias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdtgFamilias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdtgFamilias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdtgFamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdtgFamilias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdtgFamilias.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdtgFamilias.EnableHeadersVisualStyles = false;
            this.gdtgFamilias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgFamilias.Location = new System.Drawing.Point(11, 367);
            this.gdtgFamilias.Name = "gdtgFamilias";
            this.gdtgFamilias.RowHeadersVisible = false;
            this.gdtgFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdtgFamilias.Size = new System.Drawing.Size(951, 224);
            this.gdtgFamilias.TabIndex = 15;
            this.gdtgFamilias.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdtgFamilias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdtgFamilias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdtgFamilias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdtgFamilias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdtgFamilias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdtgFamilias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdtgFamilias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgFamilias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gdtgFamilias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdtgFamilias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gdtgFamilias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdtgFamilias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdtgFamilias.ThemeStyle.HeaderStyle.Height = 23;
            this.gdtgFamilias.ThemeStyle.ReadOnly = false;
            this.gdtgFamilias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdtgFamilias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdtgFamilias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdtgFamilias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdtgFamilias.ThemeStyle.RowsStyle.Height = 22;
            this.gdtgFamilias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgFamilias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel7.Location = new System.Drawing.Point(34, 210);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(137, 21);
            this.gunaLabel7.TabIndex = 28;
            this.gunaLabel7.Text = "Apellido Paterno:";
            // 
            // gtxtApellidoMTutora
            // 
            this.gtxtApellidoMTutora.BaseColor = System.Drawing.Color.White;
            this.gtxtApellidoMTutora.BorderColor = System.Drawing.Color.White;
            this.gtxtApellidoMTutora.BorderSize = 1;
            this.gtxtApellidoMTutora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtApellidoMTutora.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtApellidoMTutora.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtApellidoMTutora.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtApellidoMTutora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtApellidoMTutora.ForeColor = System.Drawing.Color.Gray;
            this.gtxtApellidoMTutora.Location = new System.Drawing.Point(177, 238);
            this.gtxtApellidoMTutora.Name = "gtxtApellidoMTutora";
            this.gtxtApellidoMTutora.PasswordChar = '\0';
            this.gtxtApellidoMTutora.SelectedText = "";
            this.gtxtApellidoMTutora.Size = new System.Drawing.Size(253, 34);
            this.gtxtApellidoMTutora.TabIndex = 25;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel2.Location = new System.Drawing.Point(78, 125);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 21);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Familias  Id:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel8.Location = new System.Drawing.Point(28, 251);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(143, 21);
            this.gunaLabel8.TabIndex = 29;
            this.gunaLabel8.Text = "Apellido Materno:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel3.Location = new System.Drawing.Point(493, 125);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(144, 21);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "Folio Aviso Cobro:";
            // 
            // gtxtApellidoPTutora
            // 
            this.gtxtApellidoPTutora.BaseColor = System.Drawing.Color.White;
            this.gtxtApellidoPTutora.BorderColor = System.Drawing.Color.White;
            this.gtxtApellidoPTutora.BorderSize = 1;
            this.gtxtApellidoPTutora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtApellidoPTutora.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtApellidoPTutora.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtApellidoPTutora.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtApellidoPTutora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtApellidoPTutora.ForeColor = System.Drawing.Color.Gray;
            this.gtxtApellidoPTutora.Location = new System.Drawing.Point(177, 197);
            this.gtxtApellidoPTutora.Name = "gtxtApellidoPTutora";
            this.gtxtApellidoPTutora.PasswordChar = '\0';
            this.gtxtApellidoPTutora.SelectedText = "";
            this.gtxtApellidoPTutora.Size = new System.Drawing.Size(253, 34);
            this.gtxtApellidoPTutora.TabIndex = 24;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel4.Location = new System.Drawing.Point(519, 243);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(118, 21);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Folio Encuesta:";
            // 
            // gtxtFamiliaId
            // 
            this.gtxtFamiliaId.BaseColor = System.Drawing.Color.White;
            this.gtxtFamiliaId.BorderColor = System.Drawing.Color.White;
            this.gtxtFamiliaId.BorderSize = 1;
            this.gtxtFamiliaId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtFamiliaId.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtFamiliaId.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtFamiliaId.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtFamiliaId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtFamiliaId.ForeColor = System.Drawing.Color.Gray;
            this.gtxtFamiliaId.Location = new System.Drawing.Point(177, 117);
            this.gtxtFamiliaId.Name = "gtxtFamiliaId";
            this.gtxtFamiliaId.PasswordChar = '\0';
            this.gtxtFamiliaId.SelectedText = "";
            this.gtxtFamiliaId.Size = new System.Drawing.Size(253, 34);
            this.gtxtFamiliaId.TabIndex = 17;
            // 
            // gtxtNombreTutora
            // 
            this.gtxtNombreTutora.BaseColor = System.Drawing.Color.White;
            this.gtxtNombreTutora.BorderColor = System.Drawing.Color.White;
            this.gtxtNombreTutora.BorderSize = 1;
            this.gtxtNombreTutora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtNombreTutora.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtNombreTutora.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtNombreTutora.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtNombreTutora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtNombreTutora.ForeColor = System.Drawing.Color.Gray;
            this.gtxtNombreTutora.Location = new System.Drawing.Point(177, 157);
            this.gtxtNombreTutora.Name = "gtxtNombreTutora";
            this.gtxtNombreTutora.PasswordChar = '\0';
            this.gtxtNombreTutora.SelectedText = "";
            this.gtxtNombreTutora.Size = new System.Drawing.Size(253, 34);
            this.gtxtNombreTutora.TabIndex = 23;
            // 
            // gtxtFolioEncuesta
            // 
            this.gtxtFolioEncuesta.BaseColor = System.Drawing.Color.White;
            this.gtxtFolioEncuesta.BorderColor = System.Drawing.Color.White;
            this.gtxtFolioEncuesta.BorderSize = 1;
            this.gtxtFolioEncuesta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtFolioEncuesta.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtFolioEncuesta.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtFolioEncuesta.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtFolioEncuesta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtFolioEncuesta.ForeColor = System.Drawing.Color.Gray;
            this.gtxtFolioEncuesta.Location = new System.Drawing.Point(643, 117);
            this.gtxtFolioEncuesta.Name = "gtxtFolioEncuesta";
            this.gtxtFolioEncuesta.PasswordChar = '\0';
            this.gtxtFolioEncuesta.SelectedText = "";
            this.gtxtFolioEncuesta.Size = new System.Drawing.Size(319, 34);
            this.gtxtFolioEncuesta.TabIndex = 19;
            // 
            // gtxtCurp
            // 
            this.gtxtCurp.BaseColor = System.Drawing.Color.White;
            this.gtxtCurp.BorderColor = System.Drawing.Color.White;
            this.gtxtCurp.BorderSize = 1;
            this.gtxtCurp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtCurp.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtCurp.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtCurp.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtCurp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtCurp.ForeColor = System.Drawing.Color.Gray;
            this.gtxtCurp.Location = new System.Drawing.Point(643, 172);
            this.gtxtCurp.Name = "gtxtCurp";
            this.gtxtCurp.PasswordChar = '\0';
            this.gtxtCurp.SelectedText = "";
            this.gtxtCurp.Size = new System.Drawing.Size(319, 34);
            this.gtxtCurp.TabIndex = 20;
            // 
            // gtxtAvisoCobro
            // 
            this.gtxtAvisoCobro.BaseColor = System.Drawing.Color.White;
            this.gtxtAvisoCobro.BorderColor = System.Drawing.Color.White;
            this.gtxtAvisoCobro.BorderSize = 1;
            this.gtxtAvisoCobro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtAvisoCobro.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtAvisoCobro.FocusedBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gtxtAvisoCobro.FocusedForeColor = System.Drawing.Color.DimGray;
            this.gtxtAvisoCobro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtAvisoCobro.ForeColor = System.Drawing.Color.Gray;
            this.gtxtAvisoCobro.Location = new System.Drawing.Point(643, 232);
            this.gtxtAvisoCobro.Name = "gtxtAvisoCobro";
            this.gtxtAvisoCobro.PasswordChar = '\0';
            this.gtxtAvisoCobro.SelectedText = "";
            this.gtxtAvisoCobro.Size = new System.Drawing.Size(319, 34);
            this.gtxtAvisoCobro.TabIndex = 22;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel6.Location = new System.Drawing.Point(583, 185);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(54, 21);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "CURP:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel5.Location = new System.Drawing.Point(45, 172);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(126, 21);
            this.gunaLabel5.TabIndex = 26;
            this.gunaLabel5.Text = "Nombre Tutora:";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::AppFamiliasIncorporacion.Properties.Resources.add_48px;
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(305, 303);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(125, 55);
            this.gunaButton1.TabIndex = 30;
            this.gunaButton1.Text = "Agregar";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::AppFamiliasIncorporacion.Properties.Resources.icons8_save_as_48px;
            this.gunaButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton2.Location = new System.Drawing.Point(532, 303);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(125, 55);
            this.gunaButton2.TabIndex = 31;
            this.gunaButton2.Text = "Guardar";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::AppFamiliasIncorporacion.Properties.Resources.icons8_usb_connected_48px;
            this.gunaButton3.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton3.Location = new System.Drawing.Point(65, 303);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(125, 55);
            this.gunaButton3.TabIndex = 32;
            this.gunaButton3.Text = "Actualizar";
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = global::AppFamiliasIncorporacion.Properties.Resources.icons8_back_arrow_48px;
            this.gunaButton4.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton4.Location = new System.Drawing.Point(761, 303);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(125, 55);
            this.gunaButton4.TabIndex = 33;
            this.gunaButton4.Text = "Regresar";
            // 
            // Editar
            // 
            this.Editar.FillWeight = 98.21972F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::AppFamiliasIncorporacion.Properties.Resources.icons8_edit_60px;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 101F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::AppFamiliasIncorporacion.Properties.Resources.icons8_delete_file_48px;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(974, 603);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gtxtApellidoMTutora);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gtxtApellidoPTutora);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gtxtFamiliaId);
            this.Controls.Add(this.gtxtNombreTutora);
            this.Controls.Add(this.gtxtFolioEncuesta);
            this.Controls.Add(this.gtxtCurp);
            this.Controls.Add(this.gtxtAvisoCobro);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gdtgFamilias);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Familias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Familias";
            this.Load += new System.EventHandler(this.Familias_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdtgFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTextBox gtxtSearch;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Button bntExit;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDataGridView gdtgFamilias;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox gtxtApellidoMTutora;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox gtxtApellidoPTutora;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox gtxtFamiliaId;
        private Guna.UI.WinForms.GunaTextBox gtxtNombreTutora;
        private Guna.UI.WinForms.GunaTextBox gtxtFolioEncuesta;
        private Guna.UI.WinForms.GunaTextBox gtxtCurp;
        private Guna.UI.WinForms.GunaTextBox gtxtAvisoCobro;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}