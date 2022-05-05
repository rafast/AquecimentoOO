using System;
using System.Collections.Generic;
using System.Linq;

namespace AquecimentoOO
{
    public class Poligono
    {

        public List<Vertice> Vertices { get; set; }
        public int QuantidadeVertices { get => Vertices.Count; set => quantidadeVertices = Vertices.Count; }

        private int quantidadeVertices;

        public Poligono(List<Vertice> vertices)
        {
            if (vertices.Count < 3)
            {
                throw new ArgumentException("O Polígono deve conter pelo menos 3 vértices");
            }
            Vertices = vertices;
        }

        public bool AddVertice(Vertice v)
        {
            var vertice = Vertices.Find(vertice => vertice == v);
            if (vertice != null)
            {
                return false;
            }
            Vertices.Add(v);
            return true;
            
        }

        public void RemoveVertice(Vertice v)
        {
            if (Vertices.Count == 3)
            {
                throw new ApplicationException("Remoção inválida! O Poligono encontra-se no tamanho mínimo.");
            }
            Vertices.Remove(v);
        }

        public float Perimetro()
        {
            float perimetro = 0;
            for (int i = 1; i < Vertices.Count; i++)
            {
                perimetro += Vertices[i-1].Distancia(Vertices[i]);
            }
            perimetro += Vertices[Vertices.Count-1].Distancia(Vertices[0]);
            return perimetro;
        }
    }
}
