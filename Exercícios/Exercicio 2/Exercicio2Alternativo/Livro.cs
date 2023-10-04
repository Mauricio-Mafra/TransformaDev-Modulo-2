using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Livro
//Atributos, minimo 3
//Métodos construtores

namespace Exercicio2Alternativo
{
    internal class Livro
    {
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public string Editora {  get; set; }
        public int Edicao { get; set; }
        public bool Emprestado { get; set; } = false;

        internal Livro(string titulo, string autor, string editora, int edicao)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Edicao = edicao;
        }


    }
}