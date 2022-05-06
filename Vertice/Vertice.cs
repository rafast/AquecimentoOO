using System;
namespace AquecimentoOO
{
    public class Vertice
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Vertice(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float Distancia (Vertice v)
        {
            float a = X - v.X;
            float b = Y - v.Y;

            float distancia = (float)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return distancia;
        }

        public void Move(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Vertice))
            {
                return false;
            }
            return (X == ((Vertice)obj).X)
                 && (Y == ((Vertice)obj).Y);
        }

    }
}
