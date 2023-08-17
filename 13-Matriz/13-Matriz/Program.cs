namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de linhas: ");
            int nLinhas = int.Parse(Console.ReadLine());

            Console.Write("Número de colunas: ");
            int nColunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[nLinhas, nColunas];

            for (int i = 0; i < nLinhas; i++)
            {
                for (int j = 0; j < nColunas; j++)
                {
                    Console.Write($"Posição {i}x{j}: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < nLinhas; i++)
            {
                for (int j = 0; j < nColunas; j++)
                {
                    Console.Write(mat[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("Númeror que deseja verificar: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < nColunas; i++)
            {
                for (int j = 0; j < nColunas; j++)
                {
                    if (mat[i, j] == x)
                    Console.WriteLine($"Posição {i}x{j}: ");
                    {
                        if (j > 0)
                        {
                            Console.Write("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        }
                        if (j > nColunas - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i - 1, j]);
                        }
                        if (i > nLinhas - 1)
                        {
                            Console.WriteLine("Baixo: " + mat[i - 1, j]);
                        }
                    }
                }
            }



        }
    }
}

/*int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++) // Poderia colocar o N diretamente no lugar de mat.GetLength()
                {
                    mat[i, j] = int.Parse(values[j]);
                    Console.Write($"Pos {i} x {j}: ");
                }
            } 

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Pos {i} x {j}: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Diagonal principal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Todos");
            int negativo = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                    if (mat[i, j] < 0)
                    {
                        negativo++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Total de nagativos: " + negativo);*/

/* double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank); // Quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); // Quantidade de linhas

            Console.WriteLine(mat.GetLength(1)); // Quantidade de colunas*/
