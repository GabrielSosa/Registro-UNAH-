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

    public partial class frmDialogPeriodo: Form
    {
        public int Periodo { set; get; }
        public frmDialogPeriodo()
        {
            try { InitializeComponent();}
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
                { e.Handled = false; }
                else { e.Handled = true; }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPeriodo.Text.Equals(string.Empty) || Convert.ToInt32(this.txtPeriodo.Text) > 3 || Convert.ToInt32(this.txtPeriodo.Text) <= 0)
                {
                    MessageBox.Show("El campo de Periodo no es correcto.\nPor favor ingréselo de nuevo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPeriodo.Text = String.Empty;

                }
                else
                {
                    this.Periodo = Convert.ToInt32(this.txtPeriodo.Text);
                    this.Hide();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
