using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circo
{
    internal class Palhaco : Artista
    {
        public bool Engracado { get; protected set; }

        internal Palhaco(string nome, string nomeArtistico, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida, bool engracado) 
            : base(nome, nomeArtistico, tempoApresentacao, dataInicio, dataSaida)
        { 
            Engracado = engracado;
        }

        public void FazerPiada()
        {
            if(!Engracado)
                Console.WriteLine($"{Nome} fez uma piada... Ninguém riu...");
            else
                Console.WriteLine($"{Nome} fez uma piada... Algumas pessoas riram!");
        }
    }
}
