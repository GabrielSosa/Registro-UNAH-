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
    public partial class frmAgregarClases : Form
    {
        private ClassEstudiante estudiante;
        private ClassConexion conexion;

        private ClassAsignatura AsignaturaSeleccionada = null;

        private List<ClassAsignatura> ListaAsignatura = new List<ClassAsignatura>();
        private List<ClassClase> ListClases = new List<ClassClase>();

        private String Fecha = String.Empty;
        private int Periodo = 0;
        private int PosibleNextIdCalificacion = 0;

        public frmAgregarClases(ClassEstudiante estudiante, ClassConexion conexion)
        {
            try
            {
                InitializeComponent();
                this.estudiante = estudiante;
                this.conexion = conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private int CalcularPeriodo()
        {
            try
            {
                int Periodo;
                int mes = Convert.ToInt32(System.DateTime.Now.ToString("MM"));
                if (mes >= 1 && mes <= 5) { Periodo = 1; }
                else if (mes >= 6 && mes <= 9) { Periodo = 2; }
                else if (mes >= 10 && mes <= 12) { Periodo = 3; }
                else { Periodo = 0; }
                return Periodo;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return 0; }

        }
        private void LLenarComboBoxAsignaturas()
        {

            this.ListaAsignatura = this.conexion.GetListaDeAsignaturasCarreraDisponibles(this.estudiante);
            this.ComboBoxAsigDispon.Items.AddRange(this.ListaAsignatura.ToArray());
            this.ComboBoxAsigDispon.Text = "Seleccione la Asignatura";

        }
        private void UpDateClasesDataGridView(List<ClassClase> ListaClases)
        {
            this.DtGrdVwCalificaciones.Rows.Clear();

            foreach (ClassClase clase in ListaClases)
            {
                this.DtGrdVwCalificaciones.Rows.Add(
                    clase.ID_CALIFICACION.ToString(),
                    clase.ID_CLASE_PLAN_ESTUDIOS.ToString(),
                    clase.ToString(),
                    clase.PERIODO.ToString(),
                    clase.CALIFICACION.ToString(),
                    clase.OBSERVACION.ToString(),
                    clase.FECHA.ToString(),
                    clase.ESTADO.ToString());
            }

        }
        private int CalcularIndiceDePromedio(List<ClassClase> ListClases)
        {

            int AcuUV = 0;
            int AcuNotas = 0;

            if (ListClases.Count.Equals(0))
            {
                return 0;
            }
            else
            {
                foreach (ClassClase cls in ListClases)
                    if (cls.CALIFICACION.Equals(0)) { }
                    else
                    {
                        int uv = Convert.ToUInt16(this.conexion.GetUV(cls.ID_CLASE_PLAN_ESTUDIOS.ToString()));
                        AcuUV += uv;

                        AcuNotas += uv * (Convert.ToUInt16(cls.CALIFICACION.ToString()));
                    }

                return Convert.ToInt32(AcuNotas / AcuUV);
            }
        }
        private void LLenarComboBoxAsignaturas(List<ClassAsignatura> ListAsig)
        {
            this.ComboBoxAsigDispon.Items.Clear();
            this.ComboBoxAsigDispon.Items.AddRange(ListAsig.ToArray());
        }

        private void frmAgregarClases_Load(object sender, EventArgs e)
        {
            try
            {
                this.Fecha = DateTime.Now.ToString("yyyy-MM-dd");
                this.Periodo = this.CalcularPeriodo();
                this.PosibleNextIdCalificacion =Convert.ToInt16( this.conexion.GetNextIdCalificaciones().ToString());

                this.LLenarComboBoxAsignaturas();
                this.lblEstudiante.Text = "Estudiante: " + this.estudiante.ToString() +
                                           "\n Número de Cuenta: " + this.estudiante.NUMERO_CUENTA;
                this.lblAño.Text = "Año: " + Convert.ToInt32(System.DateTime.Now.ToString("yyyy")); ;
                this.lblPeriodo.Text = "Periodo: " + this.Periodo;
                this.ComboBoxAsigDispon.Focus();

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

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
            try
            {
                if (this.ComboBoxAsigDispon.Text.Equals("Seleccione la Asignatura") ||
               this.txtCalificación.Text.Equals(string.Empty) ||
               Convert.ToInt32(this.txtCalificación.Text) > 100 ||
               Convert.ToInt32(this.txtCalificación.Text) < 0)
                {
                    MessageBox.Show("El campo de Calificación o Asignatura no es correcto.\nPor favor ingréselo de nuevo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCalificación.Text = String.Empty;
                }
                else
                {
                    String obs = string.Empty;
                    if (Convert.ToInt32(this.txtCalificación.Text) >= 65) { obs = "APR"; }
                    else if (Convert.ToInt32(this.txtCalificación.Text) < 65) { obs = "RPB"; }
                    else if (Convert.ToInt32(this.txtCalificación.Text).Equals(0)) { obs = "NSP"; }

                    ClassClase clase = new ClassClase(
                        this.PosibleNextIdCalificacion,
                        this.estudiante.ID_ESTUDIANTE,
                        this.AsignaturaSeleccionada.ID_CLASE_PLAN_ESTUDIOS,
                        this.Periodo,
                        this.txtCalificación.Text,
                        obs,
                        this.Fecha,
                        1);

                    this.PosibleNextIdCalificacion++;
                    this.ListClases.Add(clase);
                    this.UpDateClasesDataGridView(ListClases);
                    this.ComboBoxAsigDispon.Focus();
                    this.txtCalificación.Text = string.Empty;
                    this.lblIndice.Text = "Promedio de Índice de Clases: " + this.CalcularIndiceDePromedio(this.ListClases);

                    List<ClassAsignatura> TempListaAsignatura = this.ListaAsignatura;
                    TempListaAsignatura.Remove(AsignaturaSeleccionada);
                    this.ListaAsignatura = TempListaAsignatura;
                    this.LLenarComboBoxAsignaturas(this.ListaAsignatura);
                    this.ComboBoxAsigDispon.Text = "Seleccione la Asignatura";
                    this.AsignaturaSeleccionada = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void txtCalificación_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)08)
                { e.Handled = false; }
                else { e.Handled = true; }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            try {
                frmDialogPeriodo camc = new frmDialogPeriodo();
                camc.ShowDialog();
                this.Periodo = camc.Periodo;
                this.lblPeriodo.Text = "Periodo: " + this.Periodo;
                camc.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnEliminarCalificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeleteNots DeleteNots = new frmDeleteNots(this.ListClases);
                DeleteNots.ShowDialog();
                List<ClassClase> ListaClases = DeleteNots.listaClases;
                List<ClassClase> ListaClasesExpuls = DeleteNots.listaClasesExpuls;
                DeleteNots.Close();

                this.ListClases = ListaClases;
                this.UpDateClasesDataGridView(this.ListClases);

                foreach (ClassClase c in ListaClasesExpuls)
                {
                    ClassAsignatura asig = new ClassAsignatura(

                        c.ID_CLASE_PLAN_ESTUDIOS,
                        this.conexion.GetCodigoIdClasePorIdClasePlanEstudio(c.ID_CLASE_PLAN_ESTUDIOS.ToString()), 
                        this.conexion.GetNombrePorIdClasePlanEstudio(c.ID_CLASE_PLAN_ESTUDIOS.ToString()), 
                        this.conexion.GetUV(c.ID_CLASE_PLAN_ESTUDIOS.ToString())   );
                    this.ListaAsignatura.Add(asig);
                }
                this.LLenarComboBoxAsignaturas(this.ListaAsignatura);
                this.lblIndice.Text = "Promedio de Índice de Clases: " + this.CalcularIndiceDePromedio(this.ListClases);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnSubirCalificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (Periodo.Equals(0))
                {
                    MessageBox.Show("El Periodo es invalido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    int VerificarCantidad = 0;

                    foreach (ClassClase cd in this.ListClases)
                    { VerificarCantidad += this.conexion.SetCalificacion(cd); }

                    if (VerificarCantidad.Equals(this.ListClases.Count)) { MessageBox.Show("Calificaciones Agregadas Exitosamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else MessageBox.Show("Error al Ingresar Calificaciones", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    this.ListClases.Clear();
                    this.UpDateClasesDataGridView(this.ListClases);
                    this.LLenarComboBoxAsignaturas(this.ListaAsignatura);
                    this.PosibleNextIdCalificacion = Convert.ToInt16(this.conexion.GetNextIdCalificaciones().ToString());

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
