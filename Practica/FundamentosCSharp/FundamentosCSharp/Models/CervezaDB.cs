
using System.Data.SqlClient;
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

        //
        public void Add(Cerveza cerveza)
        {
            string query = "INSERT into cerveza(nombre, marca, alcohol, cantidad) " +
                "values(@nombre, @marca, @alcohol, @cantidad)";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Edit(Cerveza cerveza, int id)
        {
            string query = "UPDATE cerveza set nombre=@nombre," +
                "marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                "where id=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE from cerveza " +
                "where id=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
