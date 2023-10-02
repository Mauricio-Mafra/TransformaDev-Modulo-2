using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Alternativo
{
    internal class Matricula
    {
        private Aluno aluno = new();
        private Disciplina disciplina = new();
        private double notaProva1;
        private double notaProva2;
        private double notaTrabalho;

        public void setNotaProva1(double notaProva1){ this.notaProva1 = notaProva1; }
        public void setNotaProva2(double notaProva2) { this.notaProva2 = notaProva2; }
        public void setNotaTrabalho(double notaTrabalho) { this.notaTrabalho = notaTrabalho; }
        public void setAluno(Aluno aluno) { this.aluno = aluno; }

        public double getNotaProva1() {  return notaProva1; }
        public double getNotaProva2() { return notaProva2; }
        public double getNotaTrabalho() {  return notaTrabalho; }
        public Aluno getAluno() { return aluno; }


        internal Matricula(){
            aluno = new();
            disciplina = new();
            notaProva1 = 0;
            notaProva2 = 0;
            notaTrabalho = 0;
        }

        internal Matricula (Aluno aluno, Disciplina disciplina)
        {
            this.aluno = aluno;
            this.disciplina = disciplina;
        }

        

        /// <summary>
        /// Calcula a média do aluno matriculado.
        /// </summary>
        /// <returns></returns>
        public double CalcularMedia()
        {

            double pesoP1 = disciplina.getPesoProva1();
            double pesoP2 = disciplina.getPesoProva2();
            double pesoTrabalho = disciplina.getPesoTrabalho();

            double media = (notaProva1 * pesoP1 + notaProva2 * pesoP2 + notaTrabalho * pesoTrabalho) / (pesoP1 + pesoP2 + pesoTrabalho);

            return Math.Round(media, 2);
        }
    }
}
