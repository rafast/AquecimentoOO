using System;

namespace AquecimentoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Piramide");
            Piramide p = new Piramide(8);
            p.Desenha();
            Console.ReadLine();
        }
    }
}
