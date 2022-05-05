using System;

namespace AquecimentoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Lista Intervalo");
            ListaIntervalo intervalos = new ListaIntervalo();

            Intervalo intervaloManha = new Intervalo(new DateTime(2022, 05, 02, 08, 50, 00),
                                                     new DateTime(2022, 05, 02, 11, 25, 00));
            Intervalo intervaloTarde = new Intervalo(new DateTime(2022, 05, 02, 13, 30, 00),
                                                     new DateTime(2022, 05, 02, 16, 40, 00));
            Intervalo intervaloNoite = new Intervalo(new DateTime(2022, 05, 02, 19, 15, 00),
                                                     new DateTime(2022, 05, 02, 23, 45, 00));
            Intervalo intervaloIntersecao = new Intervalo(new DateTime(2022, 05, 02, 08, 15, 00),
                                                     new DateTime(2022, 05, 02, 12, 30, 00));

            intervalos.Add(intervaloNoite);
            intervalos.Add(intervaloTarde);            
            intervalos.Add(intervaloManha);
            intervalos.Add(intervaloIntersecao);
            intervalos.Imprime();
        }
    }
}
