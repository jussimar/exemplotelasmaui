using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appExemploAgenda15.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        /*public int AnoNascimento { get; set; }*/

        public DateTime DataNascimento { get; set; }

        /*public int idade
        {
            get
            {
                int idade = 2024 - AnoNascimento;
                return idade;
            }
        }*/

        public int calcIdade
        {
            get
            {
                int dias = DateTime.Now.Subtract(DataNascimento).Days;
                return dias/365;
                
            }
        }
    }
}
