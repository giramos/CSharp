using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// HERENCIA
namespace FundamentosCSharp.Models
{
    public class Cerveza : Bebida, IBebidaAlchólica
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        /// <summary>
        /// Constructor base -> hereda del padre
        /// </summary>
        public Cerveza() : base("Cerveza", 500)
        {

        }
        /// <summary>
        /// Constructor con parametros opcionales (Nota: al final siempre)
        /// </summary>
        /// <param name="Cantidad"></param>
        /// <param name="Nombre"></param>
        public Cerveza(int Cantidad = 1, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("El max permido de una cerveza es 10");
        }
    }
}
