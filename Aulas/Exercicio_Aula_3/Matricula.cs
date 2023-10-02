using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula_3
{
    internal class Matricula
    {
        private string nome;
        private double notaProva1;
        private double notaProva2;
        private double notaTrabalho;
        internal Matricula(string nome, double notaProva1, double notaProva2, double notaTrabalho)
        {
            this.nome = nome;
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
            this.notaTrabalho = notaTrabalho;
        }

        internal Matricula()
        {
            nome = "";
            notaProva1 = 0;
            notaProva2 = 0;
            notaTrabalho = 0;
    }

        internal Matricula(string nome)
        {
            this.nome = nome;
        }

        public void RegistrarNotas(double notaProva1, double notaProva2, double notaTrabalho) {
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
            this.notaTrabalho = notaTrabalho;
        }

        public void RegistrarNotaProva1(double notaProva1)
        {
            this.notaProva1 = notaProva1;
        }
        public void RegistrarNotaProva2(double notaProva2)
        {
            this.notaProva2 = notaProva2;
        }
        public void RegistrarNotaTrabalho(double notaTrabalho)
        {
            this.notaTrabalho = notaTrabalho;
        }

        internal double CalcularMediaFinal()
        {   
            
            double media =  (notaProva1 * 2.5 + notaProva2 * 2.5 + notaTrabalho * 2) / 7;
            return Math.Round(media,2);
        }

        public string getNome()
        {
            return nome;
        }

        public double getNotaProva1()
        {
            return notaProva1;
        }
        public double getNotaProva2()
        {
            return notaProva2;
        }
        public double getNotaTrabalho()
        {
            return notaTrabalho;
        }
    }
}
