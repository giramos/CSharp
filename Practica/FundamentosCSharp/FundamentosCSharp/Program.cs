using FundamentosCSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FundamentosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SERIALIZACION

            //Cerveza cerveza = new Cerveza(10, "Cerveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);

            // DESERALIZACION
            string miJson = File.ReadAllText("objeto.txt");
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);

            //"{ Cantidad: 10, Nombre: "Cerveza", cosas: []}" // ObjetoJSON
        }
    }
}
