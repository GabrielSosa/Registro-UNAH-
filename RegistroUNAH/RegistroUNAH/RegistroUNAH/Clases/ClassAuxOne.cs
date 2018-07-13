using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUNAH
{
    public class ClassAuxOne
    {

        public Object ID_ESTUDIANTE { set; get; }
        public Object FECHA { set; get; }
        public Object PESO { set; get; }



        public ClassAuxOne(object id, object fecha, object peso)
        {
            this.ID_ESTUDIANTE = id;
            this.FECHA = fecha;
            this.PESO = peso;
        }

        public override string ToString()
        {
            return this.PESO.ToString();
        }
    }
}
