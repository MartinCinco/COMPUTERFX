namespace WindowsForms.FORMULARIO
{
    partial class FrmAlumnos
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
            this.TbNoControl = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbDireccion = new System.Windows.Forms.TextBox();
            this.TbTelefono = new System.Windows.Forms.TextBox();
            this.TbEdad = new System.Windows.Forms.TextBox();
            this.TbSexo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DgvAlumnos = new System.Windows.Forms.DataGridView();
            this.noControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSCUELADataSet = new WindowsForms.ESCUELADataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alumnosTableAdapter = new WindowsForms.ESCUELADataSetTableAdapters.AlumnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSCUELADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TbNoControl
            // 
            this.TbNoControl.Location = new System.Drawing.Point(46, 12);
            this.TbNoControl.Name = "TbNoControl";
            this.TbNoControl.Size = new System.Drawing.Size(100, 20);
            this.TbNoControl.TabIndex = 0;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(46, 38);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(100, 20);
            this.TbNombre.TabIndex = 1;
            // 
            // TbDireccion
            // 
            this.TbDireccion.Location = new System.Drawing.Point(46, 64);
            this.TbDireccion.Name = "TbDireccion";
            this.TbDireccion.Size = new System.Drawing.Size(100, 20);
            this.TbDireccion.TabIndex = 2;
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(46, 90);
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(100, 20);
            this.TbTelefono.TabIndex = 3;
            // 
            // TbEdad
            // 
            this.TbEdad.Location = new System.Drawing.Point(46, 116);
            this.TbEdad.Name = "TbEdad";
            this.TbEdad.Size = new System.Drawing.Size(100, 20);
            this.TbEdad.TabIndex = 4;
            // 
            // TbSexo
            // 
            this.TbSexo.Location = new System.Drawing.Point(46, 142);
            this.TbSexo.Name = "TbSexo";
            this.TbSexo.Size = new System.Drawing.Size(100, 20);
            this.TbSexo.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(148, 236);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(229, 236);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(310, 236);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(148, 265);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta.TabIndex = 9;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(229, 265);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiarCampos.TabIndex = 10;
            this.BtnLimpiarCampos.Text = "LimpiarCampos";
            this.BtnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(310, 265);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // DgvAlumnos
            // 
            this.DgvAlumnos.AutoGenerateColumns = false;
            this.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noControlDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.DgvAlumnos.DataSource = this.alumnosBindingSource;
            this.DgvAlumnos.Location = new System.Drawing.Point(152, 12);
            this.DgvAlumnos.Name = "DgvAlumnos";
            this.DgvAlumnos.Size = new System.Drawing.Size(617, 218);
            this.DgvAlumnos.TabIndex = 12;
            // 
            // noControlDataGridViewTextBoxColumn
            // 
            this.noControlDataGridViewTextBoxColumn.DataPropertyName = "NoControl";
            this.noControlDataGridViewTextBoxColumn.HeaderText = "NoControl";
            this.noControlDataGridViewTextBoxColumn.Name = "noControlDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.eSCUELADataSet;
            // 
            // eSCUELADataSet
            // 
            this.eSCUELADataSet.DataSetName = "ESCUELADataSet";
            this.eSCUELADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 303);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvAlumnos);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiarCampos);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.TbSexo);
            this.Controls.Add(this.TbEdad);
            this.Controls.Add(this.TbTelefono);
            this.Controls.Add(this.TbDireccion);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.TbNoControl);
            this.Name = "FrmAlumnos";
            this.Text = "FrmAlumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSCUELADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNoControl;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbDireccion;
        private System.Windows.Forms.TextBox TbTelefono;
        private System.Windows.Forms.TextBox TbEdad;
        private System.Windows.Forms.TextBox TbSexo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DgvAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ESCUELADataSet eSCUELADataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private ESCUELADataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    }
}