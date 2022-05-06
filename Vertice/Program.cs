using System;

namespace AquecimentoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Vertice!");
            Console.WriteLine("Criando o Vertice A = (3,6)");
            Vertice A = new Vertice(3, 6);
            Console.WriteLine("Criando o Vertice B = (9,4)");
            Vertice B = new Vertice(9, 4);
            Console.WriteLine($"A distancia entre o Vertice A e B é {A.Distancia(B)}");
            Console.WriteLine($"O Vertice A é igual ao Vertice B ? {A.Equals(B)}");
            Console.WriteLine("Chamando o metodo Move do Vertice A passando como arguemento as coordenadas do Vertice B");
            A.Move(B.X, B.Y);
            Console.WriteLine($"O Vertice A é igual ao Vertice B ? {A.Equals(B)}");
            Console.WriteLine($"As coodenadas de A é X = {A.X} e Y = {A.Y}");            
        }
    }
}
