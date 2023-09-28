using Aula_1;

namespace Aula1
{
    class Program
    {
        static void Main()
        {
            Controle dualSense = new Controle();
            dualSense.cor = "Branco";
            dualSense.qtdBotoes = 17;
            dualSense.qtdJoysticks = 2;
            dualSense.acelerometro = true;
            dualSense.halJoysticks = false;
            dualSense.perfilAtual = 1;

            Console.WriteLine(dualSense);

            Controle xbox = new Controle()
            {
                cor = "Preto",
                qtdBotoes = 18,
                qtdJoysticks = 2,
                acelerometro = false,
                halJoysticks = false,
                perfilAtual = 2
            };

            Console.WriteLine(xbox);

            List<Controle> controles = 

            //Pessoas
            //  Alunos
            //  Instrutores
            //Equipamentos
            //Pesos
            //Exercícios
            //Áreas







    }
    }

}