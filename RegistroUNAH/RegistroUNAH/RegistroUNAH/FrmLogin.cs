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
    public partial class FrmLogin : Form
    {
        private ClassConexion conexion = new ClassConexion();
        private ClassEstudiante estudiante;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {

                if (this.txtNumeroCuenta.Text != string.Empty /*&& this.txtContraseña.Text != string.Empty*/)
                {
                   
                    this.estudiante = this.conexion.GetEstudiante(this.txtNumeroCuenta.Text);
                    try
                    {
                        if (estudiante.NUMERO_CUENTA.Equals(this.txtNumeroCuenta.Text) /*&& estudiante.Contraseña.Equals(this.txtContraseña.Text)*/)
                        {
                            MessageBox.Show("Bienvenid@ " + estudiante.P_NOMBRE, "!!Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frmPrincipal principal = new frmPrincipal(this.conexion,this.estudiante);
                            principal.ShowDialog();
                            this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show(String.Format("Cuenta o clave incorrecta"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.txtContraseña.Text = string.Empty;
                        this.txtNumeroCuenta.Text = string.Empty;
                        this.txtNumeroCuenta.Focus();
                        estudiante = null;
                    }
                }
                else if (this.txtNumeroCuenta.Text.Equals(string.Empty) || this.txtContraseña.Text.Equals(string.Empty))
                { MessageBox.Show("¡¡¡¡ATENCIÓN!!!!" + "\n" + "Los campos no pueden estar vacios.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop); }


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());}
        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)08)
                { e.Handled = false; }
                else { e.Handled = true; }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
