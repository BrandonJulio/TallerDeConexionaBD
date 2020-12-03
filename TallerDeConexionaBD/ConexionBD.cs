using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TallerDeConexionaBD
{
    class ConexionBD
    {
        string cadena = ConfigConnetion.connectionString;

        public SqlConnection conectarbd = new SqlConnection();


        public ConexionBD()
        {

            conectarbd.ConnectionString = cadena;
        }

        public string abrir()
        {

            try
            {
                string mensaje;
                conectarbd.Open();
                mensaje = "Conexion Abierta";
                conectarbd.Close();
                return mensaje;
            }
            catch (Exception ex)
            {
                return @"Error al abrir la base de datos : {ex.Message}";
            }
            finally { conectarbd.Close(); }

        }
        public void cerrar()
        {

            conectarbd.Close();

        }
    }
}
