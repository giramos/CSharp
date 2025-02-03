using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// HERENCIA
namespace FundamentosCSharp.Models
{
    internal class Cerveza: Bebida
    {
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
        public Cerveza(int Cantidad=1, string Nombre="Cerveza") : base(Nombre, Cantidad)
        {

        }
    }
}
