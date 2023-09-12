using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int anoNascimento { get; set; }
        public string CPF { get; set; }

        public Cliente() { }

        public Cliente(string nome, int anoNascimento, string CPF)
        {
            this.Nome = nome;
            this.CPF = CPF;
            this.anoNascimento = anoNascimento;
        }
    }

    public class Banco 
{
    public int Numero { get; set; }
    public string Nome { get; set; }

    public Banco() { }

    public Banco(string nome, int numero)
    {
        this.Numero = numero;
        this.Nome = nome;
    }
}

    public class Agencia
{
    public int Numero { get; set; }
    public string CEP { get; set; }
    public string Telefone { get; set; }

    public Agencia() { }

    public Agencia(int numero,string CEP, string telefone)
    {
        this.Numero = numero;
        this.CEP = CEP;
        this.Telefone = telefone;
    }
}

}
