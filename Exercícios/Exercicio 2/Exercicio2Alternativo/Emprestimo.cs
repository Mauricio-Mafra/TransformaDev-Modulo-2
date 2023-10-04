using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Emprestimo
//Propriedades:
//    DataEmprestimo
//    DataEstorno
//    DataEstimadaEstorno
//    Pessoa
//    Livro

namespace Exercicio2Alternativo
{
    internal class Emprestimo
    {
        public DateTime DataEmprestimo { get; private set; } = DateTime.MinValue;
        public DateTime DataEstorno { get; private set; }
        public DateTime DataEstimadaEstorno { get; private set; }
        private Pessoa? pessoa;
        private Pessoa Pessoa { 
            get { 
                return pessoa;
            } 

            set {
                if (value.PossuiEmprestimoAberto)
                {
                    Console.WriteLine($"{value.Nome} ainda tem um empréstimo em aberto, realize a devolução antes de solicitar um novo empréstimo.");
                    livro = null;
                    return;
                }
                pessoa = value;
            }
        }
        private Livro? livro;
        private Livro Livro {
            get { return livro; }
            
            set {
                if (value.Emprestado)
                {
                    Console.WriteLine($"O livro {value.Titulo} não está disponível no momento. Por favor, aguarde sua devolução.");
                    livro = null;
                    return;
                }
                livro = value;
            } 
        }

        internal Emprestimo(Pessoa pessoa, Livro livro) {
            Pessoa = pessoa;
            Livro = livro;
        }

        public void Emprestar() { 
            if(Livro == null || Pessoa == null) {
                Console.WriteLine("Não foi possível realizar o empréstimo.");
                return;
            }
            if(DataEmprestimo != DateTime.MinValue)
            {
                Console.WriteLine("Empréstimo já realizado.");
                return;
            }

            DataEmprestimo = DateTime.Now;
            DataEstimadaEstorno = DataEmprestimo.AddDays(7);
            Livro.Emprestado = true;
            Pessoa.PossuiEmprestimoAberto = true;

            Console.WriteLine($"Empréstimo do livro {Livro.Titulo} realizado com sucesso." +
                $"\nData de devolução: {DataEstimadaEstorno.ToShortDateString()}\n");
        }
        public void Devolver(DateTime dataEstorno) {
            if (DataEmprestimo == DateTime.MinValue)
            {
                Console.WriteLine("Devolução não realizada - não há um empréstimo em aberto no momento.");
                return;
            }
            DataEstorno = dataEstorno;

            if (DataEstimadaEstorno.CompareTo(DataEstorno) < 0)
            {
                Console.WriteLine("Devolução realizada com atraso.\n" +
                $"Data devolução: {DataEstorno}");
            }
            Livro.Emprestado = false;
            Pessoa.PossuiEmprestimoAberto = false;

            Console.WriteLine("Devolução realizada com sucesso!\n" +
                $"Data devolução: {DataEstorno}");
        }

        public void ImprimirEmprestimo()
        {
            Console.WriteLine($"Cliente: {Pessoa.Nome}");
            Console.WriteLine($"Livro: {Livro.Titulo}");
            Console.WriteLine($"Data empréstimo: {DataEmprestimo}");
            Console.WriteLine($"Data estimada estorno: {DataEstimadaEstorno}");
        }
    }
}