using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Livro
    {
        public string titulo;
        public string editora;
        public string autor;
        public int edicao;
        private bool emprestado;

        internal Livro()
        {
            titulo = "";
            editora = "";
            autor = "";
            edicao = 0;
            emprestado = false;
        }

        internal Livro(string titulo, string editora, string autor,int edicao, bool emprestado)
        {
            this.titulo = titulo;
            this.editora = editora;
            this.autor = autor;
            this.edicao = edicao;
            this.emprestado = emprestado;
        }

        public void setEmprestado(bool emprestado) { this.emprestado = emprestado; }
        public bool getEmprestado() {  return emprestado; }

    }
}
