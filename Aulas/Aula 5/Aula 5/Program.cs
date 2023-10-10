//Vamos criar um sistema que represente um circo.
//Neste sistema teremos a classe pai Artista e seus filhos Malabarista, Equilibrista e Palhaço.
//Na classe Artista teremos o Nome, o tempo de apresentação, a data de inicio, data de saída (que pode ser vazia) e se está atualmente ativo. Teremos também um método para exibir as informações e um para registrar a data de saída de algum artista e inativar seu cadastro.
//Crie testes dos seus objetos filhos.


namespace Circo
{
    class Program
    {
        static void Main()
        {
            Malabarista malabarista1 = new Malabarista(nome:"Vitor", nomeArtistico:"Vetor", tempoApresentacao: 10, dataInicio: new DateTime(2010,10,9), dataSaida: new DateTime(2019, 1, 29), qtdObjetos: 4, utensilio:"batatas");
            malabarista1.ImprimirArtista();
            malabarista1.FazerMalabarismo();
            Console.WriteLine("\n");

            Equilibrista equilibrista1 = new Equilibrista("Fernanda", "Equilibrium", 10, new DateTime(2017, 2, 14), null, "cordas");
            equilibrista1.ImprimirArtista();
            equilibrista1.Equilibrar();
            Console.WriteLine("\n");

            Palhaco palhaco = new Palhaco("Mauricio", "...", 10, new DateTime(2020, 10, 9), null, false);
            palhaco.ImprimirArtista();
            palhaco.FazerPiada();

            palhaco.RegistrarSaida();
            Console.WriteLine("\n");


            palhaco.ImprimirArtista();
        }
    }

}