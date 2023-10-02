using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Pessoa
    {
        public string nome { get; set; }
        private int idPessoa;
        private bool possuiEmprestimo;

        internal Pessoa(string nome, int idPessoa)
        {
            this.nome = nome;
            this.idPessoa = idPessoa;
            this.possuiEmprestimo = false;
        }
        internal Pessoa() {
            nome = "";
            idPessoa = 0;
            possuiEmprestimo = false;
        }

        public bool getPossuiEmprestimo() { return possuiEmprestimo; }
        public void setPossuiEmprestimo(bool possuiEmprestimo) { this.possuiEmprestimo = possuiEmprestimo; }

        public int getIdPessoa() { return idPessoa; }
        public void setIdPessoa(int idPessoa) {  this.idPessoa = idPessoa; }
       
    }
}
