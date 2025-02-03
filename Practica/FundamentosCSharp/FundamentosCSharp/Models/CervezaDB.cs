using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace FundamentosCSharp.Models
{
    class CervezaDB
    {
        private string connectionString = "Data Source=DESKTOP-3829VRG;Initial Catalog=FundamentosCSharp;Integrated Security=True";

        
        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();
            string query = "SELECT nombre, marca, alcohol, cantidad FROM cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cerveza cerveza = new Cerveza();
                    cerveza.Nombre = reader.GetString(0);
                    cerveza.Marca = reader.GetString(1);
                    cerveza.Alcohol = reader.GetInt32(2);
                    // Asigna cantidad si es necesario
                    cervezas.Add(cerveza);
                }
                connection.Close();
            }
            return cervezas;
        }
    }
}
