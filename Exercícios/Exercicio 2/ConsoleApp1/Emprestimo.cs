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

namespace ConsoleApp1
{
    internal class Emprestimo
    {
        private DateTime dataEmprestimo;
        private DateTime dataEstorno;
        private DateTime dataEstimadaEstorno;
        private Pessoa locatario;
        private Livro livro;

        internal Emprestimo(DateTime dataEmprestimo, DateTime dataEstimadaEstorno, Pessoa locatario, Livro livro)
        {
            this.dataEmprestimo = dataEmprestimo;
            this.dataEstimadaEstorno = dataEstimadaEstorno;
            this.locatario = locatario;
            this.livro = livro;
        }

        internal Emprestimo(Pessoa locatario, Livro livro)
        {
            this.locatario = locatario;
            this.livro = livro;
        }
        internal Emprestimo() {
            this.dataEmprestimo = new DateTime();
            this.dataEstorno = new DateTime();
            this.dataEstimadaEstorno = new DateTime();
            this.locatario = new Pessoa();
            this.livro = new Livro();
        }

        public DateTime getDataEmprestimo() { return  dataEmprestimo; }
        public DateTime getDataEstimadaEstorno() {  return dataEstimadaEstorno; }
        public DateTime getDataEstorno() { return dataEstorno; }
        public Pessoa getPessoa() { return locatario; }
        public Livro getLivro() {  return livro; }


        public void Emprestar()
        {   
            if (locatario.getPossuiEmprestimo())
            {
                Console.WriteLine($"{locatario.nome} ainda não realizou a devolução de um empréstimo anterior.\n" +
                    $"Realize a devolução e tente novamente\n");
            }
            else if (livro.getEmprestado())
            {
                Console.WriteLine($"O livro {livro.titulo} está indisponível atualmente.\n" +
                    $"Por favor, aguarde a devolução do mesmo.\n");
            }
            else
            {
                locatario.setPossuiEmprestimo(true);
                livro.setEmprestado(true);
                dataEmprestimo = DateTime.Today;
                dataEstimadaEstorno = this.dataEmprestimo.AddDays(7);

                Console.WriteLine($"Emprestimo do livro {livro.titulo} foi realizado com sucesso.");
                Console.WriteLine($"Data prevista para devolução: {dataEstimadaEstorno.ToShortDateString()}\n");
            }

        }

        public string Devolver(bool forcarAtraso)
        {   
            if(forcarAtraso)
                this.dataEstorno = DateTime.Today.AddDays(10);
            else
                this.dataEstorno = DateTime.Today;

            this.locatario.setPossuiEmprestimo(false);
            this.livro.setEmprestado(false);

            if(this.dataEstorno.CompareTo(this.dataEstimadaEstorno) > 0 )
            {   
                return $"Data estimada para devolução: {dataEstimadaEstorno}" +
                    $"\nData da devolução: {dataEstorno}\n" +
                    $"Devolução realizada com atraso.\n";
            }
            else
            {
                return $"Data estimada para devolução: {dataEstimadaEstorno}\n" +
                    $"Data da devolução: {dataEstorno}\n" +
                    $"Devolução realizada com sucesso, obrigado!\n";
            }
        }
    }
}
