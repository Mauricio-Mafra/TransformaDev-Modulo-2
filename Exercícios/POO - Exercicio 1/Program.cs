using System;
using Ex1;

namespace Ex1{
    class Program
    {
        static void Main()
        {
            Matricula aluno1 = new(
                nome: "Maurício",
                notaProva1:6,
                notaProva2:9,
                notaTrabalho: 8
                );

            Console.WriteLine($"Nome: {aluno1.nome}");
            Console.WriteLine($"Nota da prova 1: {aluno1.getNotaProva1()}");
            Console.WriteLine($"Nota da prova 2: {aluno1.getNotaProva2()}");
            Console.WriteLine($"Nota do trabalho: {aluno1.getNotaTrabalho()}");
            Console.WriteLine($"Média: {aluno1.CalcularMedia()}  -  {aluno1.nome} está {(aluno1.CalcularMedia() > 7 ? "aprovado.": "reprovado.")}\n");


            Matricula aluno2 = new();
            aluno2.nome = "Maria";
            aluno2.setNotaProva1(8);
            aluno2.setNotaProva2(10);
            aluno2.setNotaTrabalho(10);

            Console.WriteLine($"Nome: {aluno2.nome}");
            Console.WriteLine($"Nota da prova 1: {aluno2.getNotaProva1()}");
            Console.WriteLine($"Nota da prova 2: {aluno2.getNotaProva2()}");
            Console.WriteLine($"Nota do trabalho: {aluno2.getNotaTrabalho()}");
            Console.WriteLine($"Média: {aluno2.CalcularMedia()}  -  {aluno2.nome} está {(aluno2.CalcularMedia() > 7 ? "aprovada." : "reprovada.")}\n");

            Matricula aluno3 = new(nome: "Bob");
            aluno3.setNotaProva1(4);
            aluno3.setNotaProva2(8);
            aluno3.setNotaTrabalho(3);

            Console.WriteLine($"Nome: {aluno3.nome}");
            Console.WriteLine($"Nota da prova 1: {aluno3.getNotaProva1()}");
            Console.WriteLine($"Nota da prova 2: {aluno3.getNotaProva2()}");
            Console.WriteLine($"Nota do trabalho: {aluno3.getNotaTrabalho()}");
            Console.WriteLine($"Média: {aluno3.CalcularMedia()}  -  {aluno3.nome} está {(aluno3.CalcularMedia() > 7 ? "aprovado." : "reprovado.")}\n");



        }
    }
}