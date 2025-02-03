
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
        static async Task Main(string[] args)
        {
            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza() { Alcohol = 7, Cantidad = 10, Nombre = "Estrella", Marca = "Lala" },
                new Cerveza() { Alcohol = 8, Cantidad = 11, Nombre = "Mahou", Marca = "Aguila" },
                new Cerveza() { Alcohol = 68, Cantidad = 20, Nombre = "Damm", Marca = "Fuensanta" },
                new Cerveza() { Alcohol = 33, Cantidad = 120, Nombre = "CocaCola", Marca = "Pompeii" },
            };

            List<Bar> bares = new List<Bar>()
            {
                new Bar("El Bar")
                {
                    cervezas = new List<Cerveza>()
                    {
                        new Cerveza() { Alcohol = 7, Cantidad = 10, Nombre = "Estrella", Marca = "Lala" },
                        new Cerveza() { Alcohol = 8, Cantidad = 11, Nombre = "Mahou", Marca = "Aguila" },
                        new Cerveza() { Alcohol = 68, Cantidad = 20, Nombre = "Damm", Marca = "Fuensanta" },

                    }

                },
                new Bar("El Bar2")
                { cervezas = new List<Cerveza>()
                    {
                        new Cerveza() { Alcohol = 7, Cantidad = 10, Nombre = "Estrella", Marca = "Lala" },
                         new Cerveza() { Alcohol = 33, Cantidad = 120, Nombre = "CocaCola", Marca = "Pompeii" },

                    }
                },
                new Bar("El Bar3")
                { cervezas = new List<Cerveza>()
                    {
                        new Cerveza() { Alcohol = 44, Cantidad = 22, Nombre = "Vino", Marca = "Pomp" },
                         new Cerveza() { Alcohol = 2, Cantidad = 4, Nombre = "Leche", Marca = "Cuca" },

                    }
                }
            };

        }
    }
}
