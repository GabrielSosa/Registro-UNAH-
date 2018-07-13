using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUNAH
{
    public class ClassClase
    {

        public Object ID_CALIFICACION { set; get; }
        public Object ID_ESTUDIANTES { set; get; }
        public Object ID_CLASE_PLAN_ESTUDIOS { set; get; }
        public Object PERIODO { set; get; }
        public Object CALIFICACION { set; get; }
        public Object OBSERVACION { set; get; }
        public Object FECHA { set; get; }
        public Object ESTADO { set; get; }

        private ClassConexion conexion = new ClassConexion();


        public ClassClase() { }

        public ClassClase(
                object id,
                object id_estudiante,
                object id_clase_plan,
                object periodo,
                object calificacion,
                object obs,
                object fehca,
                object estado)
        {
            this.ID_CALIFICACION = id;
            this.ID_ESTUDIANTES = id_estudiante;
            this.ID_CLASE_PLAN_ESTUDIOS = id_clase_plan;
            this.PERIODO = periodo;
            this.CALIFICACION = calificacion;
            this.OBSERVACION = obs;
            this.FECHA = fehca;
            this.ESTADO = estado;
        }

      
        public override string ToString()
        {
            return this.conexion.GetNombrePorIdClasePlanEstudio(this.ID_CLASE_PLAN_ESTUDIOS.ToString()).ToString();
        }

    }
}
