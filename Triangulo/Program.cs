using System;

namespace AquecimentoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Triangulo");
            Console.WriteLine("Criando um Triangulo com os Vértices A(7,3), B(-1,2) e C(5, 1)");
            Triangulo t = new Triangulo(new Vertice(7, 3), new Vertice(-1, 2), new Vertice(5, 1));
            Console.WriteLine($"O Perímetro é : {t.Perimetro}");
            Console.WriteLine($"O seu tipo é : {t.Tipo}");
            Console.WriteLine($"A sua área é : {t.Area}");
        }
    }
}
