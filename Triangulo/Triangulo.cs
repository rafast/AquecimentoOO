using System;
using System.Collections.Generic;
using System.Linq;

namespace AquecimentoOO
{
    public class Triangulo
    {
        public enum TiposTriangulo {
            equilátero, isósceles, escaleno
        };

        public Vertice A { get; private set; }
        public Vertice B { get; private set; }
        public Vertice C { get; private set; }
        public float Perimetro { get; private set; }
        public TiposTriangulo Tipo { get; private set; }
        public float Area { get; set; }


        public Triangulo(Vertice a, Vertice b, Vertice c)
        {
            A = a;
            B = b;
            C = c;

            if (!ehTriangulo())
            {
                throw new ArgumentException("Os vértices fornecidos não formam um triangulo");
            }
            
            Perimetro = GetLadosOrdenados().Sum();
            Tipo = GetTipoTriangulo();
            Area = CalculaArea();
        }

        private float CalculaArea()
        {
            var lados = GetLadosOrdenados();
            float a = lados[0];
            float b = lados[1];
            float c = lados[2];
            float S = Perimetro / 2;

            return (float) Math.Sqrt(S * (S - a) * (S - b) * (S - c));
        }

        private TiposTriangulo GetTipoTriangulo()
        {
            var lados = GetLadosOrdenados();

            float maiorLado = lados[2];
            float ladoA = lados[1];
            float ladoB = lados[0];

            if((maiorLado == ladoA) && maiorLado == ladoB)
            {
                return TiposTriangulo.equilátero;
            }

            if ((maiorLado != ladoA) && (maiorLado != ladoB) && (ladoA != ladoB))
            {
                return TiposTriangulo.escaleno;
            }

            return TiposTriangulo.isósceles;
        }

        private bool ehTriangulo()
        {
            float[] lados = GetLadosOrdenados();
            float maiorLado = lados[0];

            if (lados[1] + lados[2] >= maiorLado)
            {
                return true;
            }

            return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Triangulo))
            {
                return false;
            }
            return (A == ((Triangulo)obj).A) &&
                   (B == ((Triangulo)obj).B) &&
                   (C == ((Triangulo)obj).C);
        }

        public float[] GetLadosOrdenados()
        {
            float[] ladosOrdenados = new float[] { A.Distancia(B), B.Distancia(C), C.Distancia(A) };
            Array.Sort(ladosOrdenados);
            return ladosOrdenados;
        }

         
    }
}
