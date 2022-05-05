using System;
namespace AquecimentoOO
{
    public class Piramide
    {

        public int N { get; set; }

        public Piramide(int n)
        {
            if(n < 1)
            {
                throw new ArgumentException("O argumento N não pode ser menor que 1");
            }

            this.N = n;


        }

        public void Desenha()
        {
            int larguraDaLinha = 0;
            int countLinha = 0;
            int countComplementoLinha = 0;
           
            for (int i = 1; i <= N; i++)
            {
                //Preenche e conta os vazios iniciais da linha
                for (int space = 1; space <= N - i; space++)
                {
                    Console.Write(" ");
                    countLinha++;
                }
                
                //Percorre e preenche os caracteres da linha
                while (larguraDaLinha != 2 * i - 1)
                {
                    //Primeira metade da piramide
                    if (countLinha <= N -1)
                    {
                        Console.Write((larguraDaLinha + 1));                        
                        countLinha++;
                    }
                    //Segunda metade da piramide
                    else
                    {
                        countComplementoLinha++;
                        Console.Write((larguraDaLinha + 1 - 2 * countComplementoLinha));                
                    }

                    larguraDaLinha++;
                }
                larguraDaLinha = 0;
                countLinha = 0;
                countComplementoLinha = 0;

                Console.WriteLine();
            }
        }
    }
}
