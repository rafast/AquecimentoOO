using System;
using System.Collections.Generic;

namespace AquecimentoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Poligono");
            Vertice verticeA = new Vertice(7, 3);
            Vertice verticeB = new Vertice(-1, 2);
            Vertice verticeC = new Vertice(5, 1);
            List<Vertice> listaVertices = new List<Vertice>() { verticeA, verticeB, verticeC };
            Poligono poligono = new Poligono(listaVertices);
            Console.WriteLine($"A quantidade de Vertices do Poligono é: {poligono.QuantidadeVertices}");
            Vertice verticeD = new Vertice(0, 3);
            Console.WriteLine("Adicionando um novo Vertice ao Poligono.");
            poligono.AddVertice(verticeD);
            Console.WriteLine($"A quantidade de Vertices do Poligono é: {poligono.QuantidadeVertices}");
            Console.WriteLine("Adicionando um Vertice que já existe ao Poligono.");
            poligono.AddVertice(verticeA);
            Console.WriteLine($"A quantidade de Vertices do Poligono é: {poligono.QuantidadeVertices}");
            Console.WriteLine("Removendo um Vertice do Poligono.");
            poligono.RemoveVertice(verticeD);
            Console.WriteLine($"A quantidade de Vertices do Poligono é: {poligono.QuantidadeVertices}");
            Console.WriteLine($"O Perimetro do Poligono é: {poligono.Perimetro()}");
        }
    }
}
