using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// HERENCIA
namespace FundamentosCSharp.Models
{
    internal class Vino : Bebida, IBebidaAlchólica
    {
        public int Alcohol { get; set; }
        /// <summary>
        /// Constructor base -> hereda del padre
        /// </summary>
        public Vino() : base("Vino", 500)
        {

        }
        /// <summary>
        /// Constructor con parametros opcionales (Nota: al final siempre)
        /// </summary>
        /// <param name="Cantidad"></param>
        /// <param name="Nombre"></param>
        public Vino(int Cantidad = 1, string Nombre = "Vino") : base(Nombre, Cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("El max permido de un vino es 10");
        }
    }
}
