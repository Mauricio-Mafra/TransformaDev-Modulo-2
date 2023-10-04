using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula_4
{
    internal class Gerente
    {
        public int Matricula {  get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Agencia { get; set; }

        private string cpf;

        public string Cpf
        {
            get { 
                return cpf;
            }
            set { if(value.Count() == 11)
                {
                    cpf = value;

                }
                else
                {
                    Console.WriteLine("Valor inválido");
                }
            }
        }


        public Gerente(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }


    }
}
