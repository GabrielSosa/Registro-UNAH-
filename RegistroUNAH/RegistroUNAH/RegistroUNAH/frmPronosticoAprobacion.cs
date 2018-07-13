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
    public partial class frmPronosticoAprobacion : Form
    {
        private ClassEstudiante estudiante;
        private ClassConexion conexion;

        private ClassAsignatura AsignaturaSeleccionada = null;

        private List<ClassAsignatura> ListaAsignatura = new List<ClassAsignatura>();
        private List<ClassAsignatura> ListaAsignaturaEvaluando = new List<ClassAsignatura>();

        private List<float> ListAPRGlobal = new List<float>();

        
        public frmPronosticoAprobacion(ClassConexion conexion, ClassEstudiante estudiante)
        {
            try {  InitializeComponent();
                this.conexion = conexion;
                this.estudiante = estudiante;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
           
        }

        private void LLenarComboBoxAsignaturas()
        {

            this.ListaAsignatura = this.conexion.GetListaDeAsignaturasCarreraDisponibles(this.estudiante);
            this.ComboBoxAsigDispon.Items.AddRange(this.ListaAsignatura.ToArray());
            this.ComboBoxAsigDispon.Text = "Seleccione la Asignatura";

        }

        private void LLenarComboBoxAsignaturas(List<ClassAsignatura> ListAsig)
        {
            this.ComboBoxAsigDispon.Items.Clear();
            this.ComboBoxAsigDispon.Items.AddRange(ListAsig.ToArray());
            this.ComboBoxAsigDispon.Text = "Seleccione la Asignatura";
        }

        private void UpDateClasesDataGridView(List<ClassAsignatura> ListAsignaturas)
        {
            this.DtGrdVwCalificaciones.Rows.Clear();

            foreach (ClassAsignatura asg in ListAsignaturas)
            {
                this.DtGrdVwCalificaciones.Rows.Add(
                    asg.ID_CLASE_PLAN_ESTUDIOS.ToString(),
                    asg.Asignatura.ToString(),
                    asg.UV.ToString(),
                    asg.PorcentajeAPR.ToString(),
                    asg.PorcentajeRPB.ToString()
                    );    

            }

        }
        
        private int GetALLPESOUV(List<ClassAsignatura> listAsig) {
            try {
                int sum = 0;

                foreach (ClassAsignatura asg in listAsig) { sum += Convert.ToInt16(asg.UV.ToString()); }

                return sum;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return 0; }
        }

        private int GetALLPESOUV(List<ClassAsignatura> listAsig, ClassAsignatura menosAsignatura)
        {
            try
            {
                int sum = 0;

                foreach (ClassAsignatura asg in listAsig)
                {
                    if (AsignaturaSeleccionada.ID_CLASE_PLAN_ESTUDIOS.ToString().Equals(menosAsignatura.ID_CLASE_PLAN_ESTUDIOS.ToString()))
                    { }
                    else
                    {
                        sum += Convert.ToInt16(asg.UV.ToString());
                    }
                }
                return sum;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return 0; }
        }

        private void GetPorcentajeARP(List<float> list) {

            try {

                float sum = 0;

                foreach (float x in list) {

                    sum += x;
                }

                this.lblProbAprob.Text = "PROBABILIDAD DE APROBAR \nTODAS LAS CLASES: " + Math.Round( (sum / list.Count)*100)+"%";

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
        }


        private void frmPronosticoAprobacion_Load(object sender, EventArgs e)
        {
            try
            {

                this.LLenarComboBoxAsignaturas();
                this.lblEstudiante.Text = "Estudiante: " + this.estudiante.ToString() +
                                           "\n Número de Cuenta: " + this.estudiante.NUMERO_CUENTA;
                this.ComboBoxAsigDispon.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());}
        }

        private void ComboBoxAsigDispon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.AsignaturaSeleccionada = this.ComboBoxAsigDispon.SelectedItem as ClassAsignatura;
                this.lblDescripcion.Text = "Asignatura: " + this.AsignaturaSeleccionada.Asignatura + "\nUnidades Valorativas: " + this.AsignaturaSeleccionada.UV;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {

                if (this.AsignaturaSeleccionada != null) {

                    this.ListaAsignaturaEvaluando.Add(this.AsignaturaSeleccionada);
                    this.ListaAsignatura.Remove(this.AsignaturaSeleccionada);
                    this.AsignaturaSeleccionada = null;

                    this.LLenarComboBoxAsignaturas(this.ListaAsignatura);
                    this.UpDateClasesDataGridView(this.ListaAsignaturaEvaluando);
          
                }
                else { MessageBox.Show("No ha seleccionado ningún Asignatura", "REGISTRO UNAH", MessageBoxButtons.OK, MessageBoxIcon.Error); }
              

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {

                this.ListAPRGlobal.Clear();

                if (this.chkbNivel1.Checked.Equals(true))
                {

                    List<ClassAsignatura> ListAux = this.ListaAsignaturaEvaluando;
                    int indiceList = 0;
                    foreach (ClassAsignatura asg in ListAux)
                    {
                        int peso = this.GetALLPESOUV(this.ListaAsignaturaEvaluando) - (Convert.ToUInt16(asg.UV.ToString()));

                        List<ClassAuxOne> aux = this.conexion.GetDatosNivel1PartOne(asg.CODIGO.ToString(), peso);

                        float universo = Convert.ToInt16(aux.Count);
                        float universoAPR = Convert.ToInt16(this.conexion.GetCantidadDeClasesAPRNivel1PartTwio(aux, asg.ID_CLASE_PLAN_ESTUDIOS.ToString()));

                        float apr = universoAPR / universo;
                        float rpb = 1 - apr;
                        this.ListAPRGlobal.Add(apr);


        
                            this.ListaAsignaturaEvaluando[indiceList].PorcentajeAPR = (100 * apr);
                            this.ListaAsignaturaEvaluando[indiceList].PorcentajeRPB = (100 * rpb);

                

                        indiceList++;
                    }

                }

                if (this.chkbNivel2.Checked.Equals(true))
                {

                    List<ClassAsignatura> ListAux = this.ListaAsignaturaEvaluando;
                    int indiceList = 0;
                    float cantiadGlobalARP = Convert.ToSingle(this.conexion.GetCantidadAPRGobal().ToString());
                    foreach (ClassAsignatura asg in ListAux)
                    {

                        float cantidadARPPesoPeso = Convert.ToSingle(this.conexion.GetCantidadAPRGobalPorPeso(asg.UV.ToString()));

                        float apr = cantidadARPPesoPeso / cantiadGlobalARP;
                        float rpb = 1 - apr;
                        this.ListAPRGlobal.Add(apr);

                            this.ListaAsignaturaEvaluando[indiceList].PorcentajeAPR = (100 * apr);
                            this.ListaAsignaturaEvaluando[indiceList].PorcentajeRPB = (100 * rpb);

                

                        indiceList++;
                    }


                    }
                this.UpDateClasesDataGridView(this.ListaAsignaturaEvaluando);
                this.GetPorcentajeARP(this.ListAPRGlobal);
               
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try

            {
                this.AsignaturaSeleccionada = new ClassAsignatura();
                this.ListaAsignatura = new List<ClassAsignatura>();
                this.ListaAsignaturaEvaluando = new List<ClassAsignatura>();

                this.LLenarComboBoxAsignaturas();
                this.DtGrdVwCalificaciones.Rows.Clear();

                this.ListAPRGlobal = new List<float> ();

                this.LLenarComboBoxAsignaturas();

                this.lblEstudiante.Text = "Estudiante: " + this.estudiante.ToString() +
                                           "\n Número de Cuenta: " + this.estudiante.NUMERO_CUENTA;
                this.ComboBoxAsigDispon.Focus();

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());}
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
        }
        

    }
}
