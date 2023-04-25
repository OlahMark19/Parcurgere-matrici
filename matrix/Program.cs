using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. NSEV\n2. Spirala\n3. Chenar\n4. Diagonala Principala\n5. Diagonala Secundara\n6. Romb\n7. Tricolor");
            Console.Write("Choose a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                NSEV();
            }
            else if (n == 2)
            {
                Spirala();
            }
            else if (n == 3)
            {
                Chenar();
            }
            else if (n == 4)
            {
                diagonala_principala();
            }
            else if (n == 5)
            {
                diagonala_secundara();
            }
            else if (n == 6)
            {
                Romb();
            }
            else if (n == 7)
            {
                Tricolor();
            }
          
           
        }
        static void NSEV()
        {
            int n = 9;
            int[,] matrix = new int[n, n];

            for (int i = 0; i <= n / 2; i++)
                for (int j = i; j < n - i; j++)
                {
                    matrix[i, j] = 1;
                    matrix[j, n - i - 1] = 2;
                    matrix[n - i - 1, j] = 3;
                    matrix[j, i] = 4;
                } 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Spirala()
        {
            int n = 9, step = 0;
            int[,] matrix = new int[n, n];

            for (int k = 0; k < n / 2; k++)
            {
                for (int i = k; i < n - k - 1; i++)
                    matrix[k, i] = step;
                step++;
                for (int i = k; i < n - k - 1; i++)
                    matrix[i, n - k - 1] = step;
                step++;
                for (int i = k; i < n - k - 1; i++)
                    matrix[n - k - 1, n - i - 1] = step;
                step++;
                for (int i = k; i < n - k - 1; i++)
                    matrix[n - i - 1, k] = step;
                step++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Chenar()
        {
            int n = 9;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n - 1; i++)
                matrix[0, i] = 1;
            for (int i = 0; i < n - 1; i++)
                matrix[i, n - 1] = 2;
            for (int i = 0; i < n - 1; i++)
                matrix[n - 1, n - i - 1] = 3;
            for (int i = 0; i < n - 1; i++)
                matrix[n - i - 1, 0] = 4;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void diagonala_principala()
        {
            int n = 9;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                        matrix[i, j] = 1;
                    if (i < j)
                        matrix[i, j] = 2;
                }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void diagonala_secundara()
        {
            int n = 9;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i + j > n - 1)
                        matrix[i, j] = 1;
                    if (i + j < n - 1)
                        matrix[i, j] = 2;
                }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static void Romb()
        {
            int n = 9;
            int[,] matrix = new int[n, n];
            
            for(int i = 0; i < n/2; i++)
            {
                for(int j = 0; j < n/2; j++)
                {
                    if(i + j < n / 2 - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[n / 2 + i, n / 2 + j] = 1;
                    }

                    if(i >= j)
                    {
                        matrix[n / 2 + i, j] = 1;
                    }
                    else
                    {
                        matrix[i, n / 2 + j] = 1;
                    }

                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static void Tricolor()
        {
            int n = 9;
            int[,] matrix = new int [n, n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j < n / 3)
                        matrix[i, j] = 5;
                    else if (j < 2 * n / 3)
                        matrix[i, j] = 3;
                    else
                        matrix[i, j] = 1;
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
