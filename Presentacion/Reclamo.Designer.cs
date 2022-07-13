namespace Presentacion
{
    partial class Reclamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reclamo));
            this.lblIniciarReclamo = new System.Windows.Forms.Label();
            this.lblIncidente = new System.Windows.Forms.Label();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechaHora = new System.Windows.Forms.Timer(this.components);
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.incidenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOBRETITODataSet = new Presentacion.POBRETITODataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIncidente = new System.Windows.Forms.ComboBox();
            this.fKIncidenteCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCalle = new System.Windows.Forms.ComboBox();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Presentacion.POBRETITODataSetTableAdapters.CategoriaTableAdapter();
            this.pOBRETITODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenteTableAdapter = new Presentacion.POBRETITODataSetTableAdapters.IncidenteTableAdapter();
            this.callesTableAdapter = new Presentacion.POBRETITODataSetTableAdapters.CallesTableAdapter();
            this.lblHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIncidenteCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciarReclamo
            // 
            this.lblIniciarReclamo.AutoSize = true;
            this.lblIniciarReclamo.Font = new System.Drawing.Font("Bahnschrift Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarReclamo.ForeColor = System.Drawing.Color.DimGray;
            this.lblIniciarReclamo.Location = new System.Drawing.Point(73, 45);
            this.lblIniciarReclamo.Name = "lblIniciarReclamo";
            this.lblIniciarReclamo.Size = new System.Drawing.Size(181, 29);
            this.lblIniciarReclamo.TabIndex = 13;
            this.lblIniciarReclamo.Text = "Iniciar Reclamo";
            // 
            // lblIncidente
            // 
            this.lblIncidente.AutoSize = true;
            this.lblIncidente.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIncidente.Location = new System.Drawing.Point(173, 148);
            this.lblIncidente.Name = "lblIncidente";
            this.lblIncidente.Size = new System.Drawing.Size(65, 16);
            this.lblIncidente.TabIndex = 14;
            this.lblIncidente.Text = "Incidente: ";
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoría.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoría.Location = new System.Drawing.Point(173, 108);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(69, 16);
            this.lblCategoría.TabIndex = 15;
            this.lblCategoría.Text = "Categoría: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(286, 249);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 31);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DimGray;
            this.btnVolver.Location = new System.Drawing.Point(559, 253);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(686, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 23;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(706, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(706, 201);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(76, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-109, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(547, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 16);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "fecha ";
            // 
            // fechaHora
            // 
            this.fechaHora.Enabled = true;
            this.fechaHora.Interval = 1000;
            this.fechaHora.Tick += new System.EventHandler(this.fecha_Tick);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalle.Location = new System.Drawing.Point(173, 189);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 16);
            this.lblCalle.TabIndex = 30;
            this.lblCalle.Text = "Calle: ";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAltura.Location = new System.Drawing.Point(390, 190);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 16);
            this.lblAltura.TabIndex = 31;
            this.lblAltura.Text = "Altura: ";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(445, 186);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(69, 23);
            this.txtAltura.TabIndex = 32;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged_1);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidenteBindingSource, "idCategoria", true));
            this.cmbCategoria.DataSource = this.categoriaBindingSource;
            this.cmbCategoria.DisplayMember = "nombre";
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(263, 108);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(251, 21);
            this.cmbCategoria.TabIndex = 33;
            this.cmbCategoria.ValueMember = "idCategoria";
            // 
            // incidenteBindingSource
            // 
            this.incidenteBindingSource.DataMember = "Incidente";
            this.incidenteBindingSource.DataSource = this.pOBRETITODataSet;
            // 
            // pOBRETITODataSet
            // 
            this.pOBRETITODataSet.DataSetName = "POBRETITODataSet";
            this.pOBRETITODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.pOBRETITODataSet;
            // 
            // cmbIncidente
            // 
            this.cmbIncidente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidenteBindingSource, "idCategoria", true));
            this.cmbIncidente.DataSource = this.fKIncidenteCategoriaBindingSource;
            this.cmbIncidente.DisplayMember = "nombre";
            this.cmbIncidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncidente.FormattingEnabled = true;
            this.cmbIncidente.Location = new System.Drawing.Point(263, 148);
            this.cmbIncidente.Name = "cmbIncidente";
            this.cmbIncidente.Size = new System.Drawing.Size(251, 21);
            this.cmbIncidente.TabIndex = 34;
            this.cmbIncidente.ValueMember = "idIncidente";
            // 
            // fKIncidenteCategoriaBindingSource
            // 
            this.fKIncidenteCategoriaBindingSource.DataMember = "FK_Incidente_Categoria";
            this.fKIncidenteCategoriaBindingSource.DataSource = this.categoriaBindingSource;
            // 
            // cmbCalle
            // 
            this.cmbCalle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.callesBindingSource, "calle", true));
            this.cmbCalle.DataSource = this.callesBindingSource;
            this.cmbCalle.DisplayMember = "calle";
            this.cmbCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalle.FormattingEnabled = true;
            this.cmbCalle.Location = new System.Drawing.Point(263, 187);
            this.cmbCalle.Name = "cmbCalle";
            this.cmbCalle.Size = new System.Drawing.Size(121, 21);
            this.cmbCalle.TabIndex = 35;
            this.cmbCalle.ValueMember = "idCalle";
            // 
            // callesBindingSource
            // 
            this.callesBindingSource.DataMember = "Calles";
            this.callesBindingSource.DataSource = this.pOBRETITODataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // pOBRETITODataSetBindingSource
            // 
            this.pOBRETITODataSetBindingSource.DataSource = this.pOBRETITODataSet;
            this.pOBRETITODataSetBindingSource.Position = 0;
            // 
            // incidenteTableAdapter
            // 
            this.incidenteTableAdapter.ClearBeforeFill = true;
            // 
            // callesTableAdapter
            // 
            this.callesTableAdapter.ClearBeforeFill = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(649, 56);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 16);
            this.lblHora.TabIndex = 36;
            this.lblHora.Text = "hora";
            // 
            // Reclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 330);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbCalle);
            this.Controls.Add(this.cmbIncidente);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCategoría);
            this.Controls.Add(this.lblIncidente);
            this.Controls.Add(this.lblIniciarReclamo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reclamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamo";
            this.Load += new System.EventHandler(this.Reclamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIncidenteCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIniciarReclamo;
        private System.Windows.Forms.Label lblIncidente;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer fechaHora;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbIncidente;
        private System.Windows.Forms.ComboBox cmbCalle;
        private POBRETITODataSet pOBRETITODataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private POBRETITODataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource pOBRETITODataSetBindingSource;
        private System.Windows.Forms.BindingSource incidenteBindingSource;
        private POBRETITODataSetTableAdapters.IncidenteTableAdapter incidenteTableAdapter;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private POBRETITODataSetTableAdapters.CallesTableAdapter callesTableAdapter;
        private System.Windows.Forms.BindingSource fKIncidenteCategoriaBindingSource;
        private System.Windows.Forms.Label lblHora;
    }
}