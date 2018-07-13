using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUNAH
{
    public class ClassEstudiante
    {

        public Object ID_ESTUDIANTE { set; get; }
        public Object INDICE_GOBAL { set; get; }
        public Object NUMERO_CUENTA { set; get; }
        public Object P_NOMBRE { set; get; }
        public Object S_NOMBRE { set; get; }
        public Object P_APELLIDO { set; get; }
        public Object S_APELLIDO { set; get; }
        public Object FECHA_INGRESO { set; get; }
        public Object ID_DEPARTAMENTO { set; get; }
        public Object ESTADO { set; get; }

        public ClassEstudiante() { }

        public ClassEstudiante(object Id, object indice, object numeroCuenta,
            object pNombre, object sNombre, object pApellido, object sApellido,
            object fecha, object idDepart, object estado) {

            this.ID_ESTUDIANTE = Id;
            this.INDICE_GOBAL = indice;
            this.NUMERO_CUENTA = numeroCuenta;
            this.P_NOMBRE = pNombre;
            this.S_NOMBRE = sNombre;
            this.P_APELLIDO = pApellido;
            this.S_APELLIDO = sApellido;
            this.FECHA_INGRESO = fecha;
            this.ID_DEPARTAMENTO = idDepart;
            this.ESTADO = estado;
        }

        public override string ToString()
        {
            return this.P_NOMBRE.ToString() + ' ' + this.S_NOMBRE.ToString() + ' ' + this.P_APELLIDO.ToString() + ' ' + this.S_APELLIDO.ToString();
        }
    }
}
