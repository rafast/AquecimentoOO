using System;
using System.Collections.Generic;
using System.Linq;

namespace AquecimentoOO
{
    public class ListaIntervalo
    {
        public List<Intervalo> listaIntervalo { get; set; }

        public ListaIntervalo()
        {
            listaIntervalo = new List<Intervalo>();
        }

        public void Add(Intervalo intervalo)
        {
            if (listaIntervalo.Count == 0)
            {
                listaIntervalo.Add(intervalo);
                return;
            }

            var temIntersecao = listaIntervalo.Where(i => i.TemIntersecao(intervalo))
                                              .Any();

            if (!temIntersecao)
            {
                listaIntervalo.Add(intervalo);
            }

        }

        public void Imprime()
        {
            var intervalosOrdenados = listaIntervalo.OrderBy(intervalo => intervalo.dataHoraInicio);

            foreach (var intervalo in intervalosOrdenados)
            {
                Console.WriteLine($"Data/hora inicio: {intervalo.dataHoraInicio}");
                Console.WriteLine($"Data/hora final: {intervalo.dataHoraFinal}");
                Console.WriteLine($"Duracao do intervalo: {intervalo.Duracao}");
                Console.WriteLine();
            }
        }
    }
}
