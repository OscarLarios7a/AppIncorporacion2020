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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.bntExit = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtFamiliaId = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtFolioEncuesta = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtAvisoCobro = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtCurp = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtNombreTutora = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtApellidoPTutora = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gtxtApellidoMTutora = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
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
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::AppFamiliasIncorporacion.Properties.Resources.estadisticas;
            this.gunaPictureBox1.Location = new System.Drawing.Point(595, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(62, 57);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
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
            this.bntExit.Image = global::AppFamiliasIncorporacion.Properties.Resources.icons8_cancel_64px;
            this.bntExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExit.Location = new System.Drawing.Point(899, 0);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 44);
            this.bntExit.TabIndex = 1;
            this.bntExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel2.Location = new System.Drawing.Point(34, 130);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 21);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Familias  Id:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel3.Location = new System.Drawing.Point(439, 188);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(144, 21);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Folio Aviso Cobro:";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel4.Location = new System.Drawing.Point(34, 188);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(118, 21);
            this.gunaLabel4.TabIndex = 4;
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
            this.gtxtFamiliaId.Location = new System.Drawing.Point(158, 117);
            this.gtxtFamiliaId.Name = "gtxtFamiliaId";
            this.gtxtFamiliaId.PasswordChar = '\0';
            this.gtxtFamiliaId.SelectedText = "";
            this.gtxtFamiliaId.Size = new System.Drawing.Size(253, 34);
            this.gtxtFamiliaId.TabIndex = 2;
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
            this.gtxtFolioEncuesta.Location = new System.Drawing.Point(158, 175);
            this.gtxtFolioEncuesta.Name = "gtxtFolioEncuesta";
            this.gtxtFolioEncuesta.PasswordChar = '\0';
            this.gtxtFolioEncuesta.SelectedText = "";
            this.gtxtFolioEncuesta.Size = new System.Drawing.Size(253, 34);
            this.gtxtFolioEncuesta.TabIndex = 3;
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
            this.gtxtAvisoCobro.Location = new System.Drawing.Point(582, 175);
            this.gtxtAvisoCobro.Name = "gtxtAvisoCobro";
            this.gtxtAvisoCobro.PasswordChar = '\0';
            this.gtxtAvisoCobro.SelectedText = "";
            this.gtxtAvisoCobro.Size = new System.Drawing.Size(380, 34);
            this.gtxtAvisoCobro.TabIndex = 4;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel5.Location = new System.Drawing.Point(22, 249);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(126, 21);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Nombre Tutora:";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(11, 300);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(951, 291);
            this.gunaDataGridView1.TabIndex = 15;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel6.Location = new System.Drawing.Point(522, 130);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(54, 21);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "CURP:";
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
            this.gtxtCurp.Location = new System.Drawing.Point(582, 117);
            this.gtxtCurp.Name = "gtxtCurp";
            this.gtxtCurp.PasswordChar = '\0';
            this.gtxtCurp.SelectedText = "";
            this.gtxtCurp.Size = new System.Drawing.Size(380, 34);
            this.gtxtCurp.TabIndex = 3;
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
            this.gtxtNombreTutora.Location = new System.Drawing.Point(154, 236);
            this.gtxtNombreTutora.Name = "gtxtNombreTutora";
            this.gtxtNombreTutora.PasswordChar = '\0';
            this.gtxtNombreTutora.SelectedText = "";
            this.gtxtNombreTutora.Size = new System.Drawing.Size(164, 34);
            this.gtxtNombreTutora.TabIndex = 5;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel7.Location = new System.Drawing.Point(324, 249);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(137, 21);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Apellido Paterno:";
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
            this.gtxtApellidoPTutora.Location = new System.Drawing.Point(467, 236);
            this.gtxtApellidoPTutora.Name = "gtxtApellidoPTutora";
            this.gtxtApellidoPTutora.PasswordChar = '\0';
            this.gtxtApellidoPTutora.SelectedText = "";
            this.gtxtApellidoPTutora.Size = new System.Drawing.Size(164, 34);
            this.gtxtApellidoPTutora.TabIndex = 6;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaLabel8.Location = new System.Drawing.Point(637, 249);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(143, 21);
            this.gunaLabel8.TabIndex = 15;
            this.gunaLabel8.Text = "Apellido Materno:";
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
            this.gtxtApellidoMTutora.Location = new System.Drawing.Point(798, 236);
            this.gtxtApellidoMTutora.Name = "gtxtApellidoMTutora";
            this.gtxtApellidoMTutora.PasswordChar = '\0';
            this.gtxtApellidoMTutora.SelectedText = "";
            this.gtxtApellidoMTutora.Size = new System.Drawing.Size(164, 34);
            this.gtxtApellidoMTutora.TabIndex = 7;
            // 
            // Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(974, 603);
            this.Controls.Add(this.gtxtApellidoMTutora);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gtxtApellidoPTutora);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gtxtNombreTutora);
            this.Controls.Add(this.gtxtCurp);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gtxtAvisoCobro);
            this.Controls.Add(this.gtxtFolioEncuesta);
            this.Controls.Add(this.gtxtFamiliaId);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Familias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Familias";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
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
        private Guna.UI.WinForms.GunaTextBox gtxtAvisoCobro;
        private Guna.UI.WinForms.GunaTextBox gtxtFolioEncuesta;
        private Guna.UI.WinForms.GunaTextBox gtxtFamiliaId;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox gtxtApellidoMTutora;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox gtxtApellidoPTutora;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox gtxtNombreTutora;
        private Guna.UI.WinForms.GunaTextBox gtxtCurp;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}