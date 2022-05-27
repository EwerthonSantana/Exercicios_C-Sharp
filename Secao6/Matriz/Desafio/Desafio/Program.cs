using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            string teste = new String("g");

            Console.Write("Informe respectivamente o número de linhas e colunas (x y): ");
            string userChoise = Console.ReadLine();
            string[] setupMatriz = userChoise.Split(" ");
            int x = int.Parse(setupMatriz[0]);
            int y = int.Parse(setupMatriz[1]);
            Console.WriteLine();

            int[,] matriz = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                Console.Write("Informe a sequência de números da linha " + i + ": ");
                string[] valuesMatriz = Console.ReadLine().Split(' ');

                for (int j = 0; j < y; j++)
                {
                    matriz[i, j] = int.Parse(valuesMatriz[j]);
                }

            }

            Console.WriteLine();

            Console.WriteLine("Sua matriz:  ");

            Console.WriteLine();

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                    if (j == 3)
                        Console.WriteLine();
                }

            Console.WriteLine();

            Console.Write("Informe o número da matriz que deseja receber especificações: ");
            int choiseNumberSpec = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    if (matriz[i, j] == choiseNumberSpec)
                    {
                        Console.WriteLine($"Posição: {i},{j}: ");

                        if (j > 0)
                        {
                            Console.WriteLine($"Número à esquerda: {matriz[i, j - 1]}");
                        }
                        if (j < matriz.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Número à direita: {matriz[i, j + 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Número à cima: {matriz[i - 1, j]}");
                        }
                        if (i < matriz.GetLength(0))
                        {
                            Console.WriteLine($"Número à baixo: {matriz[i + 1, j]}");
                        }


                    }
                }



        }

    }
}
