using System;

namespace AquecimentoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Testando a classe Intervalo");
               
                Intervalo intervaloManha = new Intervalo(new DateTime(2022, 05, 02, 08, 00, 00),
                                                         new DateTime(2022, 05, 02, 10, 00, 00));

                Intervalo intervaloTarde = new Intervalo(new DateTime(2022, 05, 02, 13, 00, 00),
                                                         new DateTime(2022, 05, 02, 15, 00, 00));

                Intervalo intervaloManhaSeteAsOnze = new Intervalo(new DateTime(2022, 05, 02, 07, 00, 00),
                                                                   new DateTime(2022, 05, 02, 11, 00, 00));                
                Console.WriteLine($"Tem intersecao entre manha e tarde ? {intervaloManha.TemIntersecao(intervaloTarde)}");
                Console.WriteLine($"Tem intersecao entre os dois intervalos da manha? {intervaloManha.TemIntersecao(intervaloManhaSeteAsOnze)}");
                Console.WriteLine($"Data/hora inicio: {intervaloManha.dataHoraInicio}");
                Console.WriteLine($"Data/hora final: {intervaloManha.dataHoraFinal}");
                Console.WriteLine($"Duração do intervalo: {intervaloManha.Duracao}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
