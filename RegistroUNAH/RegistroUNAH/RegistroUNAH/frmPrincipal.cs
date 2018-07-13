using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUNAH
{
    public partial class frmPrincipal : Form
    {
        private ClassEstudiante estudiante;
        private ClassConexion conexion;
        public frmPrincipal(ClassConexion conexion, ClassEstudiante estudiante)
        {
            try
            {
                InitializeComponent();
                this.conexion = conexion;
                this.estudiante = estudiante;

                this.toolStripStatusLabelWelcome.Text = "Bienvenid@ " + estudiante.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                FrmLogin camc = new FrmLogin();
                camc.ShowDialog();
                camc.Close();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { this.WindowState = FormWindowState.Minimized; }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); ; }
        }

        private void ClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostrarClases camc = new frmMostrarClases(this.conexion,this.estudiante);
                camc.MdiParent = this;
                camc.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());}
        }

        private void IngresarClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                frmAgregarClases camc = new frmAgregarClases( this.estudiante,this.conexion);
                camc.MdiParent = this;
                camc.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try {this.IsMdiContainer = true; }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }

        private void pRONOSTICODEAPROBACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                frmPronosticoAprobacion camc = new frmPronosticoAprobacion(this.conexion, this.estudiante);
                camc.MdiParent = this;
                camc.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
