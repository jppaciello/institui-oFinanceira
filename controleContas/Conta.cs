using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero)
        {
            this.Numero = numero;
        }
        public Conta() { }
        public long Numero { get; set; }

        public decimal Saldo { get; set; }

        public decimal Deposito(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            return Saldo;

        }

        public decimal Saque(decimal valor)
        {
            if (valor > 0)
            {
                Saldo -= valor;
                Saldo -= 0.10m;
            }
            return Saldo;
        }
    }
}