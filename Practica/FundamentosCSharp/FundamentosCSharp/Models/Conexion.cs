using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FundamentosCSharp.Models
{
    internal class Conexion
    {

        SqlConnection con = new SqlConnection();

        SqlConnectionStringBuilder patata = new();
        

        static string servidor;
        static string bd;
        static string usuario;
        static string pass;
        static string puerto;

        string cadenaConexion = "Data Source=DESKTOP-3829VRG;Initial Catalog=FundamentosCSharp;Integrated Security=True";


        public SqlConnection establecerConexion()
        {
            try
            {
                con.ConnectionString = cadenaConexion; 
                con.Open();
                
                Console.WriteLine("Conexion exito");
            }
            catch(SqlException err)
            {
                Console.WriteLine("No se logro conextar a la BS " + err.ToString());

            }
            return con;
        }
    }
}
