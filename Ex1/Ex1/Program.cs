using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mat = new string[3, 3] { {"O", "O", "O" }, { "X", "O", "O" }, { "O", "O", "X" }} ;
            Imprimir_Jogo(mat);
            Console.ReadKey();
        }
        static void Imprimir_Jogo(string[,] mat)
        {
            for (int l=0;l<mat.GetLength(1);l++)
            {
                for (int c = 0; c < mat.GetLength(0); c++)
                {
                    Console.Write(mat[l, c]);
                }
                Console.WriteLine();
            }
        }
        static void Verificar(string[,] mat)
        {

        }
    }
}
