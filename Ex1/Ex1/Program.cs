﻿using System;
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
            string[,] mat = new string[3, 3] { { "_", "_", "_" },
                                                { "_", "_", "_" },
                                                { "_", "_", "_" } };
            string jogador = "X";

            ImprimirJogo(mat);

            while (true)
            {
                //capturar input do usuario;
                //validar entrada do usuario;
                //se valida ok ->
                    //realizar jogada;
                    //trocar de jogador;
                //se não ok
                    //voltar ao inicio;
                
                jogador = TrocarJogador(jogador);


            };

            Console.WriteLine("ACABOU O JOGO REINICIA TUDO AI...");
            Console.ReadKey();
        }
        static void ImprimirJogo(string[,] mat)
        {
            Console.Clear();
            Console.WriteLine("\t[0]\t[1]\t[2]");
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                Console.Write($"[{l}]");
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("\t" + mat[l, c]);
                }
                Console.WriteLine();
            }
        }
        static bool Verificar(string[,] mat, int[] jogada)
        {
            if (int.TryParse(x, out jogada[0]) && int.TryParse(y, out jogada[1]))
            {

                if ((jogada[0] < 0 || jogada[0] > 2) || (jogada[1] < 0 || jogada[1] > 2))
                {
                    ImprimirJogo(mat);
                    Console.WriteLine("Não existe essa posição");
                    return false;
                }
                else if (mat[jogada[0], jogada[1]] != "_")
                {
                    ImprimirJogo(mat);
                    Console.WriteLine("Você não pode jogar nesta posição");
                    return false;
                }
                return true;
            }
           
        }
        static int[] Jogada(string[,] mat) 
        {
            int[] jogada = new int[2] { -1, -1 } ;
            string x, y;
           
            Console.WriteLine("Informe a linha do 0 ao 2: ");
            x = Console.ReadLine();
            Console.WriteLine("Informe a coluna do 0 ao 2: ");
            y = Console.ReadLine();

            if (int.TryParse(x, out jogada[0]) && int.TryParse(y, out jogada[1]))
            {

                if ((jogada[0] < 0 || jogada[0] > 2) || (jogada[1] < 0 || jogada[1] > 2))
                {
                    ImprimirJogo(mat);
                    Console.WriteLine("Não existe essa posição");
                }
                else if (mat[jogada[0], jogada[1]] != "_")
                {
                    ImprimirJogo(mat);
                    Console.WriteLine("Você não pode jogar nesta posição");
                }
            }
            return jogada;
        }
        static bool Jogando(string[,] mat, string jogador)
        {
            int[] jogada = Jogada(mat);

            
            mat[jogada[0], jogada[1]] = jogador;

            ImprimirJogo(mat);

            int status = VerificaStatus(mat);

            if (status > 0 && status < 3)
            {
                Console.WriteLine($"O jogador {status} ganhou");
                return false;
            }
            else if(status == 0){
                Console.WriteLine("Deu velha");
                return false;
            }
            
            return true;

        }
        static int VerificaStatus(string[,]mat)
        {
            if((mat[0,0] == mat[1,1] && mat[0,0]== mat[2, 2]) && mat[0, 0] != "_")
            {
                if(mat[0, 0] == "X")
                {
                    return 1;
                }
                else
                {                    
                    return 2;
                }
            }

            if((mat[0,2] == mat[1,1] && mat[0,2] == mat[2, 0]) && mat[0,2] != "_")
            {
                if (mat[0, 2] == "X")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            for (int l = 0; l < mat.GetLength(0); l++)
            {
                if((mat[l,0] == mat[l,1] && mat[l, 0] == mat[l, 2]) && mat[l, 0] != "_")
                {
                    if (mat[l, 0] == "X")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }

            for (int c = 0; c < mat.GetLength(0); c++)
            {
                if ((mat[0, c] == mat[1, c] && mat[0, c] == mat[2, c]) && mat[0, c] != "_")
                {
                    if (mat[0, c] == "X")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }

            int cont=0;

            for (int l = 0; l < mat.GetLength(0); l++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if(mat[l,c] != "_")
                    {
                        cont++;
                    }
                    
                }
            }

            if(cont == 9)
            {
                return 0;
            }

            return 3;
        }
        static string TrocarJogador(string jogador)
        {
            if(jogador == "x" || jogador == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
    }
}
