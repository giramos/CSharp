using FundamentosCSharp.Models;
using System;
using System.Collections.Generic;

namespace FundamentosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bebidaAlchólica = new Cerveza(100); // creamos una cerveza
            //var bebidaAlchólica = new Vino(100); // creamos un vino
            MostrarRecomendacion(bebidaAlchólica);
            List<string> lista = new List<string>();
        }

        static void MostrarRecomendacion(IBebidaAlchólica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}
