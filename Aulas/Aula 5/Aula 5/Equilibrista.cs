using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circo
{
    internal class Equilibrista : Artista
    {
        public string BaseEquilibrio { get; protected set; }

        internal Equilibrista(string nome, string nomeArtistico, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida, string baseEquilibrio)
            : base(nome, nomeArtistico, tempoApresentacao, dataInicio, dataSaida)
        {
            BaseEquilibrio = baseEquilibrio;
        }

        public void Equilibrar()
        {
            Console.WriteLine($"Estou me equilibrando em {BaseEquilibrio}.");
        }
    }
}
