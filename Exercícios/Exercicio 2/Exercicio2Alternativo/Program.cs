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



namespace Exercicio2Alternativo
{
    class Program
    {
        static void Main()
        {
            Pessoa pessoa1 = new("Mauricio", "12345678901", "Em alguma rua em algum predio");
            Pessoa pessoa2 = new("Bob", "12345678901", "Em alguma outra rua em algum outro predio");

            Livro livro1 = new("D&D Player's Handbook 5e", "Wizards", "Wizards of the Coast", 5);
            Livro livro2 = new("Percy Jackson e o Ladrão de Raios", "Rick Riordan", "Intrínseca", 1);

            Emprestimo emprestimo1 = new(pessoa1, livro1);
            emprestimo1.Emprestar();
            Emprestimo emprestimo2 = new(pessoa2, livro1);
            emprestimo2.Emprestar();

            emprestimo1.Devolver(DateTime.Now);
            emprestimo2.Emprestar();


        }
    }
}