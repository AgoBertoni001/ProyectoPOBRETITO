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
            this.pOBRETITODataSet = new Presentacion.POBRETITODataSet();
            this.incidenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenteTableAdapter = new Presentacion.POBRETITODataSetTableAdapters.IncidenteTableAdapter();
            this.pOBRETITODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Presentacion.POBRETITODataSetTableAdapters.CategoriaTableAdapter();
            this.comboBoxIncidente = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblIncidente.Location = new System.Drawing.Point(165, 177);
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
            this.lblCategoría.Location = new System.Drawing.Point(165, 137);
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
            // pOBRETITODataSet
            // 
            this.pOBRETITODataSet.DataSetName = "POBRETITODataSet";
            this.pOBRETITODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenteBindingSource
            // 
            this.incidenteBindingSource.DataMember = "Incidente";
            this.incidenteBindingSource.DataSource = this.pOBRETITODataSet;
            // 
            // incidenteTableAdapter
            // 
            this.incidenteTableAdapter.ClearBeforeFill = true;
            // 
            // pOBRETITODataSetBindingSource
            // 
            this.pOBRETITODataSetBindingSource.DataSource = this.pOBRETITODataSet;
            this.pOBRETITODataSetBindingSource.Position = 0;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.pOBRETITODataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxIncidente
            // 
            this.comboBoxIncidente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidenteBindingSource, "nombre", true));
            this.comboBoxIncidente.DataSource = this.incidenteBindingSource;
            this.comboBoxIncidente.DisplayMember = "nombre";
            this.comboBoxIncidente.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIncidente.FormattingEnabled = true;
            this.comboBoxIncidente.Location = new System.Drawing.Point(245, 176);
            this.comboBoxIncidente.Name = "comboBoxIncidente";
            this.comboBoxIncidente.Size = new System.Drawing.Size(261, 24);
            this.comboBoxIncidente.TabIndex = 20;
            this.comboBoxIncidente.ValueMember = "idIncidente";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "nombre", true));
            this.comboBox1.DataSource = this.categoriaBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "idCategoria";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 24;
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
            // Reclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 330);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxIncidente);
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
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOBRETITODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIniciarReclamo;
        private System.Windows.Forms.Label lblIncidente;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private POBRETITODataSet pOBRETITODataSet;
        private System.Windows.Forms.BindingSource incidenteBindingSource;
        private POBRETITODataSetTableAdapters.IncidenteTableAdapter incidenteTableAdapter;
        private System.Windows.Forms.BindingSource pOBRETITODataSetBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private POBRETITODataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxIncidente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}