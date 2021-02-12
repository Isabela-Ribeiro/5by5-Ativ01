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
            string[,] mat = new string[3, 3] { { "", "O", "O" }, { "X", "O", "X" }, { "O", "O", "X" } };
            string[,] jogadores = new string[2,2] { { "1", "x" }, { "2", "o" } };

            while (true)
            {
                Imprimir_Jogo(mat);
                Jogando(mat,jogadores);
                VerificaStatus();
                //Verificar(mat);
            }
            
            Console.ReadKey();
        }
        static void Imprimir_Jogo(string[,] mat)
        {
            Console.Clear();
            for (int l=0;l<mat.GetLength(1);l++)
            {
                for (int c = 0; c < mat.GetLength(0); c++)
                {
                    Console.Write(mat[l, c]);
                }
                Console.WriteLine();
            }
        }
        static bool Verificar(string[,] mat, int[] jogada)
        {
            if(mat[jogada[0],jogada[1]] != "")
            {
                Console.WriteLine("Não pode jogar nessa posicao");
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Jogando(string[,] mat, string[,] jogador)
        {
            int[] jogada = new int[2];


            do
            {
                Console.WriteLine("Informe a linha ");
                jogada[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a coluna ");
                jogada[1] = int.Parse(Console.ReadLine());
            } while (!Verificar(mat, jogada));
            mat[jogada[0],jogada[1]] = "x";
            Imprimir_Jogo(mat);
            //trocajgoador
            
        }
        static void VerificaStatus()
        {

        }
    }
}
