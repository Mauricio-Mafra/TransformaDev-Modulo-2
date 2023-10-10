//Vamos criar um sistema que represente um circo.
//Neste sistema teremos a classe pai Artista e seus filhos Malabarista, Equilibrista e Palhaço.
//Na classe Artista teremos o
//Nome,
//o tempo de apresentação,
//a data de inicio,
//data de saída (que pode ser vazia) e
//se está atualmente ativo.
//
//Teremos também um método para exibir as informações e um para registrar a data de saída de algum artista e inativar seu cadastro.
//Crie testes dos seus objetos filhos.

namespace Circo
{
    internal class Malabarista : Artista
    {
        public int QtdObjetos { get; private set; } = 0;
        public string Utensilio { get; private set; }


        internal Malabarista(string nome, string nomeArtistico, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida, int qtdObjetos, string utensilio) 
            : base(nome, nomeArtistico, tempoApresentacao, dataInicio, dataSaida)
        {

            QtdObjetos = qtdObjetos;
            Utensilio = utensilio;
        }

        public void FazerMalabarismo()
        {
            Console.WriteLine($"Estou fazendo malabarismo com {QtdObjetos} {Utensilio}.");
        }
    }
}
