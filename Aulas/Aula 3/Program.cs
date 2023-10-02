using Aula_3;
using System;
using System.Runtime.CompilerServices;

namespace Aula3
{
    class Program
    {
        static void Main()
        {
            double resultado = Somar(5,8);
            Console.WriteLine(resultado);
            Pessoa pessoa = new();

            pessoa.ImprimirDadosPessoa();


            Console.WriteLine($"Área do circulo: {CalcularAreaCirculo(14)}");
        }

        /// <summary>
        /// Retorna a soma de dois números
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public static double CalcularAreaCirculo(double raio)
        {
            double resultado = 0;
            resultado = Math.PI * Math.Pow(raio, 2);

            return resultado;

        }

        // Métodos estáticos não sofrem alterações durante a execução do programa
        // 
    }

}