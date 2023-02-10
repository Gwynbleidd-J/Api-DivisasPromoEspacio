using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Connection;

namespace DataAccess.Connection
{
    public class ConnectionDB
    {
        public static Desencriptar _des=new Desencriptar();
        public static string CadenaConexionEncript = ConfigurationManager.ConnectionStrings["DBCon_Proyecto"].ConnectionString;
        public static string CadenaConexion = _des.Desencriptarllave(CadenaConexionEncript);
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(CadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
