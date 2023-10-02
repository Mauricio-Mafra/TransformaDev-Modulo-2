using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Matricula
    {
        public string nome;
        private double notaProva1;
        private double notaProva2;
        private double notaTrabalho;       

        internal Matricula()
        {
            nome = "";
            notaProva1 = 0.0;
            notaProva2 = 0.0;
            notaTrabalho = 0.0;
        }

        internal Matricula(string nome) {  
            this.nome = nome; 
        }
        internal Matricula(string nome, double notaProva1) {
            this.nome = nome;
            this.notaProva1 = notaProva1;
        }
        internal Matricula(string nome, double notaProva1, double notaProva2)
        {
            this.nome = nome;
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
        }
        internal Matricula(string nome, double notaProva1, double notaProva2, double notaTrabalho)
        {
            this.nome = nome;
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
            this.notaTrabalho = notaTrabalho;
        }

        /// <summary>
        /// Retorna o valor atual do atributo privado - notaProva1
        /// </summary>
        /// <returns></returns>
        public double getNotaProva1()
        {
            return notaProva1;
        }

        /// <summary>
        /// Permite atualização do atributo privado - notaProva1.
        /// </summary>
        /// <param name="notaProva1"></param>
        public void setNotaProva1(double notaProva1)
        {
            this.notaProva1 = notaProva1;
        }

        /// <summary>
        /// Retorna o valor atual do atributo privado - notaProva2
        /// </summary>
        /// <returns></returns>
        public double getNotaProva2()
        {
            return notaProva2;
        }

        /// <summary>
        /// Permite atualização do atributo privado - notaProva2.
        /// </summary>
        /// <param name="notaProva2"></param>
        public void setNotaProva2(double notaProva2)
        {
            this.notaProva2 = notaProva2;
        }

        /// <summary>
        /// Retorna o valor atual do atributo privado - notaTrabalho
        /// </summary>
        /// <returns></returns>
        public double getNotaTrabalho()
        {
            return notaProva1;
        }

        /// <summary>
        /// Permite atualização do atributo privado - notaTrabalho.
        /// </summary>
        /// <param name="notaTrabalho"></param>
        public void setNotaTrabalho(double notaTrabalho)
        {
            this.notaTrabalho = notaTrabalho;
        }

        /// <summary>
        /// Calcula a média de um aluno com base em 3 atributos - notaProva1, notaProva2 e notaTrabalho.
        /// </summary>
        /// <returns></returns>
        public double CalcularMedia()
        {
            double media = (notaProva1 * 2.5 + notaProva2 * 2.5 + notaTrabalho * 2) / 7;
            return Math.Round(media,2);
        }


    }
}
