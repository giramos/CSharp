using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Models
{
     class CervezaDB
    {
        private string connectionString = "Data Source=localhost; Initial Catalog=FundamentosCSharp; User=sa; Password=123456;";   //servidor
        // nombre BBD
        // 
        // puerto por defecto

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select nombre, marca, alcohol, cantidad" +
                "from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = reader.GetString(0);
                    int cantidad = reader.GetInt32(3);
                    Cerveza cerveza = new Cerveza();
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);
                    cervezas.Add(cerveza);
                }

                connection.Close();
            }

            return cervezas;
        }
    }
}
