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
    public partial class frmMostrarClases : Form
    {
        private ClassEstudiante estudiante;
        private ClassConexion conexion;
        public frmMostrarClases(ClassConexion conexion, ClassEstudiante estudiante)
        {
            try
            {
                InitializeComponent();
                this.conexion = conexion;
                this.estudiante = estudiante;
                this.Text = "Lista de Clases: " + this.estudiante.ToString();

                this.dataGridViewClases.DataSource = conexion.GetAllClasesGridEstudiante(this.estudiante);
                this.lblIndiceGlobal.Text = "Indice Global: " + this.estudiante.INDICE_GOBAL.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); this.lblIndiceGlobal.Text = "Indice Global: 0"; }

        }

        private void frmMostrarClases_Load(object sender, EventArgs e)
        {

            try
            {
                this.lblEstudiante.Text = this.estudiante.ToString() + '\n' + this.estudiante.NUMERO_CUENTA;
                this.rbtnAllClass.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void rbtnAllClass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.conexion.GetAllClasesGridEstudiante(this.estudiante).Equals(null)) { }
                else
                {
                    this.dataGridViewClases.DataSource = this.conexion.GetAllClasesGridEstudiante(this.estudiante);
                    this.lblIndiceGlobal.Text = "Indice Global: " + Convert.ToString(Math.Round(Convert.ToDouble(this.conexion.GetIndiceGlobalPorParametroEstudianteYOBS(this.estudiante))));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); this.lblIndiceGlobal.Text = "Indice Global: 0"; }
        }

        private void rbtnAllClassAPR_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.conexion.GetAllClasesGridEstudiante(this.estudiante, "APR").Equals(null)) { }
                else
                {
                    this.dataGridViewClases.DataSource = this.conexion.GetAllClasesGridEstudiante(this.estudiante, "APR");
                    this.lblIndiceGlobal.Text = "Indice Global: " + Convert.ToString(Math.Round(Convert.ToDouble(this.conexion.GetIndiceGlobalPorParametroEstudianteYOBS(this.estudiante, "APR"))));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); this.lblIndiceGlobal.Text = "Indice Global: 0";
            }
        }

        private void rbtnAllClassRPB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.conexion.GetAllClasesGridEstudiante(this.estudiante, "RPB").Equals(null)) { }
                else
                {
                    this.dataGridViewClases.DataSource = this.conexion.GetAllClasesGridEstudiante(this.estudiante, "RPB");
                    this.lblIndiceGlobal.Text = "Indice Global: " + Convert.ToString(Math.Round(Convert.ToDouble(this.conexion.GetIndiceGlobalPorParametroEstudianteYOBS(this.estudiante, "RPB"))));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); this.lblIndiceGlobal.Text = "Indice Global: 0"; }
        }

        private void rbtnAllClassNSP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.conexion.GetAllClasesGridEstudiante(this.estudiante, "NSP").Equals(null)) { }
                else
                {
                    this.dataGridViewClases.DataSource = this.conexion.GetAllClasesGridEstudiante(this.estudiante, "NSP");
                    this.lblIndiceGlobal.Text = "Indice Global: " + Convert.ToString(Math.Round(Convert.ToDouble(this.conexion.GetIndiceGlobalPorParametroEstudianteYOBS(this.estudiante, "NSP"))));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); this.lblIndiceGlobal.Text = "Indice Global: 0"; }
        }
    }
}
