using System;

namespace Ex1Alternativo
{
    class Program
    {
        static void Main()
        {
            Disciplina disciplina1 = new Disciplina(nome:"Matemática",
                pesoProva1: 3,
                pesoProva2: 4,
                pesoTrabalho: 3);

            Aluno aluno1 = new(id: 1,
                nome: "Maurício");

            Matricula matricula = new(aluno:  aluno1, disciplina: disciplina1);

            matricula.setNotaProva1(10);
            matricula.setNotaProva2(8);
            matricula.setNotaTrabalho(10);

            double media = matricula.CalcularMedia();

            Console.WriteLine($"Média: {media} - {matricula.getAluno().nome} está {(media > 7 ? "aprovado." : "reprovado.")}");
        }
    }
}