using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RegistroUNAH
{
    public class ClassConexion
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataAdapter adapter;
        private SqlDataReader reader;

        public ClassConexion() {

            try {

                //this.conexion= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|UNAH.mdf;Integrated Security=True;Connect Timeout=30");
                //this.conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\UNAH.mdf ;Integrated Security=True;Connect Timeout=30");
                this.conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\UNAH IA.mdf ;Integrated Security=True;Connect Timeout=30");
                this.OpenConexion();
                this.CloseConexion();
                
            }
            catch (Exception e ) {
                MessageBox.Show("ERROR EN LA CONEXIÓN "+e.ToString(),"REGISTRO UNAH",MessageBoxButtons.RetryCancel);
            }    
            
        }

        public void OpenConexion()
        {
            try { conexion.Open(); }
            catch (Exception e) { MessageBox.Show(e.ToString());}

        }

        public void CloseConexion()
        {
            try { conexion.Close(); }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

        }

        public ClassEstudiante GetEstudiante(String numeroCuenta)
        {

            try
            {

                ClassEstudiante Student = new ClassEstudiante();
                string q = String.Format("select * from TBL_ESTUDIANTES where  NUMERO_CUENTA='{0}'", numeroCuenta);
                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {

                    Student = new ClassEstudiante(
                           reader["ID_ESTUDIANTE"],
                           reader["INDICE_GLOBAL"],
                           reader["NUMERO_CUENTA"],
                           reader["P_NOMBRE"],
                           reader["S_NOMBRE"],
                           reader["P_APELLIDO"],
                           reader["S_APELLIDO"],
                           reader["FECHA_INGRESO"],
                           reader["ID_DEPARTAMENTO"],
                           reader["ESTADO"]

                   );

                }
                CloseConexion();
                if (Student.Equals(null))
                {
                    Student.NUMERO_CUENTA = "NULL";
                }


                return Student;


            }
            catch (Exception e) { MessageBox.Show(e.ToString()); this.CloseConexion(); return null; }

        }

        public DataTable GetAllClasesGridEstudiante(ClassEstudiante estu)
        {
            try { 
            String sql = string.Format("select "+
                "(cast(E.CODIGO_DEPARTAMENTO as nchar(2))"+
                    "+ '-' + CAST(C.ID_CLASE as nchar(10))) CODIGO," +
                "C.NOMBRE_CLASE, " +
                "C.UV, " +
                "A.CALIFICACION, " +
                "A.PERIODO, " +
                "A.FECHA, " +
                "A.OBSERVACION " +

                "from TBL_CALIFICACIONES A " +
                    "INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B " +
                    "ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS " +
                    "INNER JOIN TBL_CLASES C " +
                    "ON B.ID_CLASE = C.ID_CLASE " +
                    "INNER JOIN TBL_ESTUDIANTES D " +
                    "ON A.ID_ESTUDIANTES = D.ID_ESTUDIANTE " +
                    "INNER JOIN TBL_DEPARTAMENTO E " +
                    "ON C.ID_DEPARTAMENTO = E.ID_DEPARTAMENTO " +
                "where D.NUMERO_CUENTA = '{0}' " +
                "ORDER BY D.ID_ESTUDIANTE, A.PERIODO, A.FECHA ",estu.NUMERO_CUENTA);

            this.comando = new SqlCommand(sql, this.conexion);

            this.OpenConexion();
            this.comando.ExecuteReader();
            this.CloseConexion();

            this.adapter = new SqlDataAdapter(this.comando);
            System.Data.DataTable tabla = new System.Data.DataTable();
            adapter.Fill(tabla);

            return tabla;
        }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }

}

        public DataTable GetAllClasesGridEstudiante(ClassEstudiante estu, string OBS)
        {
            try
            {
                String sql = string.Format("select " +
                "(cast(E.CODIGO_DEPARTAMENTO as nchar(2))" +
                    "+ '-' + CAST(C.ID_CLASE as nchar(10))) CODIGO," +
                "C.NOMBRE_CLASE, " +
                "C.UV, " +
                "A.CALIFICACION, " +
                "A.PERIODO, " +
                "A.FECHA, " +
                "A.OBSERVACION " +

                "from TBL_CALIFICACIONES A " +
                    "INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B " +
                    "ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS " +
                    "INNER JOIN TBL_CLASES C " +
                    "ON B.ID_CLASE = C.ID_CLASE " +
                    "INNER JOIN TBL_ESTUDIANTES D " +
                    "ON A.ID_ESTUDIANTES = D.ID_ESTUDIANTE " +
                    "INNER JOIN TBL_DEPARTAMENTO E " +
                    "ON C.ID_DEPARTAMENTO = E.ID_DEPARTAMENTO " +
                "where D.NUMERO_CUENTA = '{0}' AND A.OBSERVACION = '{1}' " +
                "ORDER BY D.ID_ESTUDIANTE, A.PERIODO, A.FECHA ", estu.NUMERO_CUENTA, OBS);

                this.comando = new SqlCommand(sql, this.conexion);

                this.OpenConexion();
                this.comando.ExecuteReader();
                this.CloseConexion();

                this.adapter = new SqlDataAdapter(this.comando);
                System.Data.DataTable tabla = new System.Data.DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }

}

        public Object GetIndiceGlobalPorParametroEstudianteYOBS(ClassEstudiante student, String OBS) {

            try {

                object indice = null;
                string q = String.Format("select "+

                    "SUM(A.CALIFICACION * C.UV) / SUM(C.UV) AS INDICE "+

                    "FROM TBL_CALIFICACIONES A " +
                    "INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B " +
                    "ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS " +
                    "INNER JOIN TBL_CLASES C " +
                    "ON B.ID_CLASE = C.ID_CLASE " +
                    "INNER JOIN TBL_ESTUDIANTES D " +
                    "ON A.ID_ESTUDIANTES = D.ID_ESTUDIANTE " +

                    "where D.NUMERO_CUENTA = '{0}' AND A.OBSERVACION = '{1}' ",student.NUMERO_CUENTA,OBS);

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {

                    indice =reader["INDICE"];
                       
                }

                CloseConexion();


                return indice;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }

        }
    
        public Object GetIndiceGlobalPorParametroEstudianteYOBS(ClassEstudiante student)
        {

            try
            {

                object indice = null;
                string q = String.Format("select " +

                    "SUM(A.CALIFICACION * C.UV) / SUM(C.UV) AS INDICE " +

                    "FROM TBL_CALIFICACIONES A " +
                    "INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B " +
                    "ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS " +
                    "INNER JOIN TBL_CLASES C " +
                    "ON B.ID_CLASE = C.ID_CLASE " +
                    "INNER JOIN TBL_ESTUDIANTES D " +
                    "ON A.ID_ESTUDIANTES = D.ID_ESTUDIANTE " +

                    "where D.NUMERO_CUENTA = '{0}' ", student.NUMERO_CUENTA);

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {

                    indice = reader["INDICE"];

                }

                CloseConexion();


                return indice;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }

        }

        public Object GetNextIdCalificaciones() {

            try {

                object nextIndice = null;
                string q = String.Format("select MAX(A.ID_CALIFICACION)+1 nextIndice from TBL_CALIFICACIONES A");

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {

                    nextIndice = reader["nextIndice"];

                }

                CloseConexion();


                return nextIndice;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }


        }

        public Object GetUV(String ID_CLASE_PLAN_ESTUDIOS)
        {

            try
            {

                object uv = null;
                string q = String.Format("select B.UV from TBL_CLASES_PLAN_ESTUDIOS A	INNER JOIN TBL_CLASES B	ON A.ID_CLASE = B.ID_CLASE where A.ID_CLASE_PLAN_ESTUDIOS='{0}'", ID_CLASE_PLAN_ESTUDIOS);

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {
                    uv = reader["UV"];
                }

                CloseConexion();


                return uv;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }


        }

        public Object GetNombrePorIdClasePlanEstudio(String ID_CLASE_PLAN_ESTUDIOS)
        {

            try
            {

                object name = null;
                string q = String.Format("select  B.NOMBRE_CLASE from TBL_CLASES_PLAN_ESTUDIOS A  INNER JOIN TBL_CLASES B  ON A.ID_CLASE = B.ID_CLASE where A.ID_CLASE_PLAN_ESTUDIOS = '{0}'", ID_CLASE_PLAN_ESTUDIOS);

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {
                    name = reader["NOMBRE_CLASE"];
                }

                CloseConexion();

                return name;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }


        }

        public Object GetCodigoIdClasePorIdClasePlanEstudio(String ID_CLASE_PLAN_ESTUDIOS)
        {

            try
            {

                object codigoId = null;
                string q = String.Format("select B.ID_CLASE from TBL_CLASES_PLAN_ESTUDIOS A	INNER JOIN TBL_CLASES B	 ON A.ID_CLASE = B.ID_CLASE where A.ID_CLASE_PLAN_ESTUDIOS= '{0}'", ID_CLASE_PLAN_ESTUDIOS);

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {
                    codigoId = reader["ID_CLASE"];
                }

                CloseConexion();

                return codigoId;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }


        }

        public List<ClassAsignatura> GetListaDeAsignaturasCarreraDisponibles(ClassEstudiante student) {

            try {

                String sql = String.Format("select A.ID_CLASE_PLAN_ESTUDIOS,B.ID_CLASE,B.NOMBRE_CLASE,B.UV "+
                        "FROM TBL_CLASES_PLAN_ESTUDIOS A " +
                        "INNER JOIN TBL_CLASES B " +
                        "ON A.ID_CLASE = B.ID_CLASE " +
                            "where A.ID_CLASE_PLAN_ESTUDIOS NOT IN( " +

                                "select Z.ID_CLASE_PLAN_ESTUDIOS " +
                                    "From TBL_CALIFICACIONES Z " +
                                    "INNER JOIN TBL_ESTUDIANTES X " +
                                    "ON Z.ID_ESTUDIANTES = X.ID_ESTUDIANTE " +
                       "where X.NUMERO_CUENTA = '{0}' AND Z.OBSERVACION = 'APR')"

                       , student.NUMERO_CUENTA);

                List<ClassAsignatura> listAsignaturas = new List<ClassAsignatura>();
                this.comando = new SqlCommand(sql,this.conexion);


                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {

                    listAsignaturas.Add(new ClassAsignatura(
                   
                    reader["ID_CLASE_PLAN_ESTUDIOS"],
                    reader["ID_CLASE"],
                    reader["NOMBRE_CLASE"],
                    reader["UV"]
              
                    ));

                }
                CloseConexion();

                return listAsignaturas;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }
        }

        public int SetCalificacion(ClassClase clase)
        {
            try {

                string q = String.Format("INSERT INTO TBL_CALIFICACIONES (ID_CALIFICACION,ID_ESTUDIANTES,ID_CLASE_PLAN_ESTUDIOS,PERIODO,CALIFICACION,OBSERVACION,FECHA,ESTADO) "+
                                          "VALUES ({0}, {1}, {2}, {3}, {4}, '{5}', '{6}', {7})",
                                          this.GetNextIdCalificaciones().ToString(),
                                          clase.ID_ESTUDIANTES.ToString(),
                                          clase.ID_CLASE_PLAN_ESTUDIOS.ToString(),
                                          clase.PERIODO.ToString(),
                                          clase.CALIFICACION.ToString(),
                                          clase.OBSERVACION.ToString(),
                                          clase.FECHA.ToString(),
                                          clase.ESTADO.ToString());

                this.comando = new SqlCommand(q, this.conexion);

                this.OpenConexion();
                int n = this.comando.ExecuteNonQuery();
                this.CloseConexion();

                return n;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return 0; }

        }

        public List<ClassAuxOne> GetDatosNivel1PartOne(String idCodigoClase, int peso) {
    
            try {

                String sql = String.Format("select Z.ID_ESTUDIANTES, Z.FECHA, SUM(Z.PESO) as PESO from ( "+
                        "SELECT A.ID_ESTUDIANTES, A.FECHA, SUM(UV) AS PESO " +
                        "FROM TBL_CALIFICACIONES A " +
                        "INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B " +
                        "ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS " +
                        "INNER JOIN TBL_CLASES C " +
                        "ON B.ID_CLASE = C.ID_CLASE " +
                        "WHERE FECHA IN( " +
                            "SELECT A.FECHA FROM TBL_CALIFICACIONES A " +
                            "INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B " +
                            "ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS " +
                            "WHERE B.ID_CLASE = {0}) " +
                        "AND B.ID_CLASE < > {0} " +
                        "AND ID_ESTUDIANTES IN( " +
                            "SELECT ID_ESTUDIANTES FROM TBL_CALIFICACIONES A " +
                            "INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B " +
                            "ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS " +
                            "WHERE B.ID_CLASE = {0}) " +
                    "GROUP BY ID_ESTUDIANTES, FECHA, B.ID_CLASE ) Z "+
                    "GROUP BY Z.ID_ESTUDIANTES, Z.FECHA ",idCodigoClase);

                List<ClassAuxOne> list = new List<ClassAuxOne>();
                this.comando = new SqlCommand(sql, this.conexion);


                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["PESO"].ToString()).Equals(peso))
                    {
                        list.Add(new ClassAuxOne(

                        reader["ID_ESTUDIANTES"],
                        reader["FECHA"],
                        reader["PESO"]));
                    }
                }
                this.CloseConexion();

                return list;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }
        }

        public object GetCantidadDeClasesAPRNivel1PartTwio(List<ClassAuxOne> list, String ID_CLASE_PLAN_ESTUDIOS) {
            try {

                int cantAPR = 0;

                foreach (ClassAuxOne aux in list) {

                    String sql = String.Format("select  A.OBSERVACION from TBL_CALIFICACIONES A where  A.ID_ESTUDIANTES={0} AND A.FECHA='{1}'AND A.ID_CLASE_PLAN_ESTUDIOS={2}", aux.ID_ESTUDIANTE.ToString(), this.ConvertirFechaFormatoYYYYMMDD(aux.FECHA.ToString()), ID_CLASE_PLAN_ESTUDIOS);

                    this.comando = new SqlCommand(sql, this.conexion);
                    

                    this.OpenConexion();
                    this.reader = this.comando.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["OBSERVACION"].ToString().Equals("APR"))
                        {
                            cantAPR++;
                        }
                    }
                    this.CloseConexion();
            
                  
                }
                return cantAPR;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return 0; }
        }

        private String ConvertirFechaFormatoYYYYMMDD(string fehca)
        {

            try
            {
                DateTime ds = DateTime.Parse(fehca);

                String s = ds.ToString("yyyy-MM-dd");
                return s;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }
        }

        public Object GetCantidadAPRGobal()
        { 
            try
            {

                object cant = null;
                string q = String.Format("select count(*) CANTIDAD from TBL_CALIFICACIONES WHERE OBSERVACION = 'APR'");

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {
                    cant = reader["CANTIDAD"];
                }

                CloseConexion();

                return cant;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }
        }


        public Object GetCantidadAPRGobalPorPeso(String peso)
        {
            try
            {

                object cant = null;
                string q = String.Format("SELECT COUNT(*) CANTIDAD FROM TBL_CALIFICACIONES A INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS INNER JOIN TBL_CLASES C ON B.ID_CLASE = C.ID_CLASE WHERE  C.UV = {0} AND OBSERVACION = 'APR'", peso);

                this.comando = new SqlCommand(q, this.conexion);
                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {
                    cant = reader["CANTIDAD"];
                }

                CloseConexion();

                return cant;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }
        }

        public List<ClassClase> GetAllCalificaciones()
        {

            try
            {
                String sql = String.Format("select * from TBL_CALIFICACIONES");

                List<ClassClase> list = new List<ClassClase>();
                this.comando = new SqlCommand(sql, this.conexion);


                this.OpenConexion();
                this.reader = this.comando.ExecuteReader();

                while (reader.Read())
                {

                        list.Add(new ClassClase(

                        reader["ID_CALIFICACION"],
                        reader["ID_ESTUDIANTES"],
                        reader["ID_CLASE_PLAN_ESTUDIOS"],
                        reader["PERIODO"],
                        reader["CALIFICACION"],
                        reader["OBSERVACION"],
                        reader["FECHA"],
                        reader["ESTADO"]));
                  
                }
                this.CloseConexion();

                return list;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return null; }
        }


        public int UpDateCalificacion(ClassClase oldClase, ClassClase newClase)
        {
            try
            {
                string q = String.Format("UPDATE TBL_CALIFICACIONES " +
                       "SET[ID_CALIFICACION] = {0} " +
                          ",[ID_ESTUDIANTES] = {1} " +
                          ",[ID_CLASE_PLAN_ESTUDIOS] = {2} " +
                          ",[PERIODO] = '{3}' " +
                          ",[CALIFICACION] = {4} " +
                          ",[OBSERVACION] = '{5}' " +
                          ",[FECHA] = '{6}' " +
                          ",[ESTADO] = '{7}' " +
                     "WHERE ID_CALIFICACION = {8}",
                     Convert.ToInt16(oldClase.ID_CALIFICACION.ToString()),
                     Convert.ToInt16(oldClase.ID_ESTUDIANTES.ToString()),
                     Convert.ToInt16(oldClase.ID_CALIFICACION.ToString()),
                     oldClase.PERIODO.ToString(),
                     Convert.ToInt16(oldClase.CALIFICACION.ToString()),
                     oldClase.OBSERVACION.ToString(),
                     this.ConvertirFechaFormatoYYYYMMDD(oldClase.FECHA.ToString()),
                     oldClase.ESTADO.ToString(),
                     Convert.ToInt16(newClase.ID_CALIFICACION.ToString())
                     );

                this.comando = new SqlCommand(q, this.conexion);

                OpenConexion();
                int n = this.comando.ExecuteNonQuery();
                CloseConexion();
                return n;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); this.CloseConexion(); return 0; }
         }

    }
}
