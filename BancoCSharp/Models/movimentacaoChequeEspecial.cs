using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class MovimentacaoChequeEspecial
    {
        private DateTime DataSaida { get; set; }
        private Double ValorCheque { get; set; }

        public MovimentacaoChequeEspecial(DateTime dataSaida, double valorCheque)
        {
            DataSaida = dataSaida;
            ValorCheque = valorCheque;
        }

    }



}


