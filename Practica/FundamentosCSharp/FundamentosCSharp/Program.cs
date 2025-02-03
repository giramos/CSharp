using FundamentosCSharp.Models;
using System;
using System.Collections.Generic;

namespace FundamentosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array -> se le da una dimension, mas rapido que una lista, orientado a una coleccion
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; // coleccion de numero

            int numero = numeros[0]; // acceder al primer elemento

            for (int i = 0; i < numeros.Length; i++) // recorrer 'for'
            {
                Console.WriteLine("iteracion: " + i + " - " + numeros[i]);
            }

            foreach (var n in numeros) // recorrer 'foreach'
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(" +++++++++++++++++++++ ");

            // lista -> suele implementar una interfaz, dinamica (longitud varia)
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Remove(2);

            foreach (var nu in lista)
            {
                Console.WriteLine("elemento: " + nu);
            }

            Console.WriteLine(" +++++++++++++++++++++ ");

            Console.ReadLine();

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza premium") };
            cervezas.Add(new Cerveza(500));
            Cerveza estrella = new Cerveza(200, "Cerveza de trigo");
            cervezas.Add(estrella);

            foreach (var cer in cervezas)
            {
                Console.WriteLine("cerveza: " + cer.Nombre);
            }
            // cola
            Queue<int> cola = new Queue<int>();
            // pila
        }
    }
}
