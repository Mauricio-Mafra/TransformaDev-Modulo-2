using Exercicio_Aula_3;
using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matricula aluno1 = new(nome: "Maurício",
                                        notaProva1: 7,
                                        notaProva2: 8,
                                        notaTrabalho: 9
                                        );

            Console.WriteLine($"Nome: {aluno1.getNome()}");
            Console.WriteLine($"P1: {aluno1.getNotaProva1()}");
            Console.WriteLine($"P2: {aluno1.getNotaProva2()}");
            Console.WriteLine($"Trabalho: {aluno1.getNotaTrabalho()}");
            Console.WriteLine($"Media: {aluno1.CalcularMediaFinal()}");

            Console.WriteLine($"{aluno1.getNome()} está {(aluno1.CalcularMediaFinal() > 7 ? "aprovado!" : "reprovado...")}\n");


            Matricula aluno2 = new(nome: "Vash");

            Console.WriteLine($"Nome: {aluno2.getNome()}");
            Console.WriteLine($"P1: {aluno2.getNotaProva1()}");
            Console.WriteLine($"P2: {aluno2.getNotaProva2()}");
            Console.WriteLine($"Trabalho: {aluno2.getNotaTrabalho()}\n");

            aluno2.RegistrarNotaProva1(notaProva1: 8);
            aluno2.RegistrarNotaProva2(notaProva2: 9);
            aluno2.RegistrarNotaTrabalho(notaTrabalho: 8);

            Console.WriteLine($"Nome: {aluno2.getNome()}");
            Console.WriteLine($"P1: {aluno2.getNotaProva1()}");
            Console.WriteLine($"P2: {aluno2.getNotaProva2()}");
            Console.WriteLine($"Trabalho: {aluno2.getNotaTrabalho()}");

            Console.WriteLine($"Media: {aluno2.CalcularMediaFinal()}");

            Console.WriteLine($"{aluno2.getNome()} está {(aluno2.CalcularMediaFinal() > 7 ? "aprovado!":"reprovado...")}\n");
        }
    }

}