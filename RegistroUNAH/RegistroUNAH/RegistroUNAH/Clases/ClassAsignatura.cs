using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUNAH
{
    public class ClassAsignatura
    {


        public Object ID_CLASE_PLAN_ESTUDIOS { set; get; }
        public Object CODIGO { set; get; }
        public Object Asignatura { set; get; }
        public Object UV { set; get; }

        public Object PorcentajeAPR { set; get; }
        public Object PorcentajeRPB { set; get; }


        public ClassAsignatura() { this.PorcentajeAPR = 0;this.PorcentajeRPB = 0; }

        public ClassAsignatura(object id_Clase_Plan_Estudio, object codigo, object asignatura, object uv)
        {
            this.ID_CLASE_PLAN_ESTUDIOS = id_Clase_Plan_Estudio;
            this.CODIGO = codigo;
            this.Asignatura = asignatura;
            this.UV = uv;
            this.PorcentajeAPR = 0;
            this.PorcentajeRPB = 0;
        }

        public override string ToString()
        {
            return  this.Asignatura.ToString();
        }

    }
}
