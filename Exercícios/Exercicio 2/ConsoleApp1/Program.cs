using ConsoleApp1;
using System;

//Faça um programa para controle de empréstimo de livros, com as classes Emprestimo, Livro e Pessoa. Faça uma classe de teste implementando a criação de 2 Pessoas, 5 livros e 4 emprestimos.

//Pessoa
//Atributos, minimo 3
//Métodos construtores

//Livro
//Atributos, minimo 3
//Métodos construtores

//Emprestimo
//Propriedades:
//    DataEmprestimo
//    DataEstorno
//    DataEstimadaEstorno
//    Pessoa
//    Livro

//Métodos construtores
//Métodos encapsulamento:
//    Emprestar()
//    Devolver() retorna se houve atraso 

namespace Exercicio2
{
    class Program
    {
        static void Main()
        {
            Livro livro1 = new(titulo: "D&D Player's Handbook 5e",
                editora: "Wizards of The Coast",
                autor: "Wizards of The Coast",
                edicao: 5,
                emprestado: false) ;

            Livro livro2 = new(titulo: "Percy Jackson e o Ladrão de Raios",
                editora: "Intrínseca",
                autor: "Rick Riordan",
                edicao: 1,
                emprestado: false);

            Pessoa pessoa1 = new(nome: "Maurício", idPessoa: 1);
            Pessoa pessoa2 = new(nome: "Bob", idPessoa: 2);

            Emprestimo emprestimo1 = new(locatario: pessoa1, livro: livro1);
            Emprestimo emprestimo2 = new(locatario: pessoa2, livro: livro1);

            emprestimo1.Emprestar();
            emprestimo2.Emprestar();
            Console.WriteLine(emprestimo1.Devolver(false));

            Emprestimo emprestimo3 = new(locatario: pessoa2, livro: livro2);
            emprestimo3.Emprestar();
            emprestimo2.Emprestar();

            Console.WriteLine(emprestimo3.Devolver(true));
            emprestimo2.Emprestar();


        }
    }
}