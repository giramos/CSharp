
using FundamentosCSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CervezaDB cervezaBD = new CervezaDB();
            var cervezas = cervezaBD.Get();

            foreach (var item in cervezas)
            {
                Console.WriteLine(item.Nombre);
            }

            // insertamos nuevas cervezas
            {
                Cerveza cerveza = new Cerveza(15, "Mahou");
                cerveza.Marca = "Minerva";
                cerveza.Alcohol = 6;
                cervezaBD.Add(cerveza);
            }

            // editamos una cerveza
            {
                Cerveza cerveza = new Cerveza(15, "Mahou");
                cerveza.Marca = "Minerva";
                cerveza.Alcohol = 5;
                cervezaBD.Edit(cerveza, 5);
            }

            // borrar
            {
                cervezaBD.Delete(5);
            }

            // obtener todas las cervezas

            cervezas = cervezaBD.Get();

            foreach (var item in cervezas)
            {
                Console.WriteLine($"Nombre: {item.Nombre} - Marca: {item.Marca} - Cantidad: {item.Cantidad} - Alcohol: {item.Alcohol}");
            }


        }

    }
}
