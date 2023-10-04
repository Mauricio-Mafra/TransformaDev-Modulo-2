using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Alternativo
{
   

    internal class Pessoa
    {
        public bool PossuiEmprestimoAberto { get; set; } = false;

        private string nome;
        public string Nome { 
            get { return nome; } 

            set {
                if (value.Length == 0)
                {
                    Console.WriteLine("Valor inválido para nome - valor fornecido é vazio.");
                }
                nome = value;
            }
        }

        private string cpf;
        public string Cpf { 
            get { return cpf; } 
            
            set {
                if (value.Length != 11) {
                    Console.WriteLine("Valor inválido para o cpf - deve possuir 11 digitos.");
                }
                cpf = value;
            }
        }

        private string endereco;
        public string Endereco { 
            get { return endereco; } 
            
            set {
                if (value.Length == 0) {
                    Console.WriteLine("Endereço inválido - valor fornecido é vazio.");
                }
                endereco = value;
            } 
        }

        internal Pessoa(string nome, string cpf, string endereco) {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}
