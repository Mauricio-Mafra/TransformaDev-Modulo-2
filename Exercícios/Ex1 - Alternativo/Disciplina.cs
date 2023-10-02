using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Alternativo
{
    internal class Disciplina
    {
        public string nome;
        private double pesoProva1;
        private double pesoProva2;
        private double pesoTrabalho;

        internal Disciplina()
        {
            nome = "";
            pesoProva1 = 2.5;
            pesoProva2 = 2.5;
            pesoTrabalho = 2;
        }

        internal Disciplina(string nome, double pesoProva1, double pesoProva2, double pesoTrabalho)
        {
            this.nome = nome;
            this.pesoProva1 = pesoProva1;
            this.pesoProva2 = pesoProva2;
            this.pesoTrabalho = pesoTrabalho;
        }

        public void setPesoProva1(double pesoProva1){this.pesoProva1 = pesoProva1;}
        public void setPesoProva2(double pesoProva2){this.pesoProva2 = pesoProva2;}
        public void setPesoTrabalho(double pesoTrabalho){this.pesoTrabalho = pesoTrabalho;}
        public double getPesoProva1() { return pesoProva1;}
        public double getPesoProva2() {  return pesoProva2;}
        public double getPesoTrabalho() {  return pesoTrabalho;}
    }
}
