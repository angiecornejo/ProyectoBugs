using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//using System.Data.OleDb;


namespace ProyectoBugs.Clases
{
    class Datos
    {      
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = @"Provider=SQLNCLI11;Data Source=190.30.40.40,1433;Persist Security Info=True;User ID=pav1;Initial Catalog=PAV1_3K1; password=pav12020";


        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open(); //si acá ya establecimos la conexion va todo okey
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            // si esto conecto, le paso el texto que yo quiero
            this.comando.CommandText = consultaSQL;
            tabla.Load(this.comando.ExecuteReader()); //Como es un reader es para consulta de la DB, NonQuery es para modificar la BD
            this.desconectar();
            return tabla;
        }
    }
}
