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
    public partial class frmDeleteNots : Form
    {
        public List<ClassClase> listaClases { set; get; }
        public List<ClassClase> listaClasesExpuls { set; get; }


        public frmDeleteNots(List<ClassClase> listaClases)
        {
            try
            {
                InitializeComponent();
                this.listaClases = listaClases;
                this.listaClasesExpuls = new List<ClassClase>();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void frmDeleteNots_Load(object sender, EventArgs e)
        {
            try {  this.ckedListExpuls.Items.AddRange(this.listaClases.ToArray());}
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
           
        }

        private void ckedListExpuls_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("SEGURO QUE DESEA ELIMINAR ESTA CALIFICACIÓN", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    ClassClase ClaseExpuls = ckedListExpuls.SelectedItem as ClassClase;

                    this.listaClases.Remove(ClaseExpuls);
                    this.listaClasesExpuls.Add(ClaseExpuls);

                    this.ckedListExpuls.Items.Clear();
                    this.ckedListExpuls.Items.AddRange(this.listaClases.ToArray());
                }
                else if (result == DialogResult.No)
                {
                    this.ckedListExpuls.Items.Clear();
                    this.ckedListExpuls.Items.AddRange(this.listaClases.ToArray());

                }

                if (this.ckedListExpuls.Items.Count.Equals(0)) { this.Hide(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try { this.Hide(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
