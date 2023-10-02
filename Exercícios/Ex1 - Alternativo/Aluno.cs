using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Alternativo
{
    internal class Aluno
    {
        private int id;
        public string nome;

        internal Aluno() {
            id = 0;
            nome = "";
        }

        internal Aluno(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
