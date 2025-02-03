using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Models
{
    interface IBebidaAlchólica 
    {
        public int Alcohol { get; set; } // CSharp puedes poner atributos

        public void MaxRecomendado(); // metodo
    }
}
