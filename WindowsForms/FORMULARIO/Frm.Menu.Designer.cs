namespace WindowsForms.FORMULARIO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Alumnos = new System.Windows.Forms.Button();
            this.Btn_Materias = new System.Windows.Forms.Button();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Alumnos
            // 
            this.Btn_Alumnos.Location = new System.Drawing.Point(239, 39);
            this.Btn_Alumnos.Name = "Btn_Alumnos";
            this.Btn_Alumnos.Size = new System.Drawing.Size(75, 23);
            this.Btn_Alumnos.TabIndex = 0;
            this.Btn_Alumnos.Text = "Alumnos";
            this.Btn_Alumnos.UseVisualStyleBackColor = true;
            this.Btn_Alumnos.Click += new System.EventHandler(this.Btn_Alumnos_Click);
            // 
            // Btn_Materias
            // 
            this.Btn_Materias.Location = new System.Drawing.Point(239, 87);
            this.Btn_Materias.Name = "Btn_Materias";
            this.Btn_Materias.Size = new System.Drawing.Size(75, 23);
            this.Btn_Materias.TabIndex = 1;
            this.Btn_Materias.Text = "Materias";
            this.Btn_Materias.UseVisualStyleBackColor = true;
            this.Btn_Materias.Click += new System.EventHandler(this.Btn_Materias_Click);
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.Location = new System.Drawing.Point(239, 145);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.Btn_Menu.TabIndex = 2;
            this.Btn_Menu.Text = "Menu";
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(239, 204);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 3;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 292);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Menu);
            this.Controls.Add(this.Btn_Materias);
            this.Controls.Add(this.Btn_Alumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Alumnos;
        private System.Windows.Forms.Button Btn_Materias;
        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.Button Btn_Salir;
    }
}

