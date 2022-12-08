using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.FORMULARIO
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            
        }
        private void Btn_Alumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlumnos frm = new FrmAlumnos();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void Btn_Materias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMaterias frm = new FrmMaterias();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInscripciones frm = new FrmInscripciones();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
