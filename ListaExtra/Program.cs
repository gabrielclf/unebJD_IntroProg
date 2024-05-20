using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRepeticao
{
    internal class Program
    {
        //Para Q2
        static void mostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < 13; i++){
                for (int j = 0; j < 4; j++) {
                    if (j == 0){
                        Console.Write("Jogo ");
                    }
                    Console.Write("\t"+matriz[i,j]);
                }
                Console.Write("\n");
            }
        }
        static void imprimirMatrizQuadrada(int[,] mat, int n,int m){
        //escrevendo matriz
            for (int i = 0; i < n; i++){
                 for (int j = 0; j < m; j++){
                    Console.Write("\t " + mat[n,m]);
                 }
                Console.Write("\n");
            }
        }
        static void Main(string[] args){
        //Atividade para ponto extra
        //Estudantes: Gabriel Fonseca e Felipe Morais, Turma 05
        /* Questão 1 - Matriz Ortogonal

        //Matriz ortogonal https://pt.wikipedia.org/wiki/Matriz_ortogonal
        // Em Álgebra linear, uma matriz quadrada é dita ortogonal se sua matriz inversa coincide com sua matriz transposta

        int n = 0, m = 0;
        Random random = new Random();   
        Console.WriteLine("Informe o número de linhas [n] para a matriz: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o número de colunas [m] para a matriz: ");
        m = Convert.ToInt32(Console.ReadLine());
        if (n == m){ //matrizes ortogonais são matrizes quadradas = nº de linhas = nº colunas

         //matriz inversa: Uma matriz é dita invertível se ela multiplicada a outra matriz M^-1 é igual à matriz identidade

         //matriz transposta: Uma matriz que são trocadas as posições entre linhas e colunas EX:
         //uma matriz 2x3 tem uma transposta 3x2

         //matriz identidade é uma matriz diagonal, cujos elementos da diagonal principal são todos iguais a 1

         int i, j;

         int[,] matrix = new int[n, m];
         double[,] transposta = new double[n, m];
         double[,] inversa = new double[n, m];
         
         // Preencher a primeira matriz: M
         Console.WriteLine("Informe valores para preencher a matriz M: ");

         for (i = 0; i < n; i++)
         {
             for (j = 0; j < m; j++)
             {
                 matrix[n, m] = Convert.ToInt32(Console.ReadLine());
                 transposta[n, m] = matrix[m, n];
             }
         }

         //Criando a matriz inversa
         Console.WriteLine("Informe a matriz inversa: ");
         for (i = 0; i < n; i++)
         {
             for (j = 0; j < m; j++)
             {
                 Console.WriteLine($"Informe o valor para a posição {n}x{m}");
                 inversa[n, m] = Convert.ToDouble(Console.ReadLine());
                 
             }
         }
        //Confirmando se a matriz é ortogonal
         bool confirma = true;
         for (i = 0; i < n; i++){
             for (j = 0; j < m; j++){
                 if (inversa[n,m] != transposta[n, m]) {  confirma = false; break; }
             }
         }
        }

         if (confirma) {
             Console.WriteLine("A matriz inserida é ortogonal"); 
         } else { 
            Console.WriteLine("A matriz inserida não é ortogonal"); 
         }
        */
            /*
            * Questão 2 - Apostas Esportivas
            int pontos = 13, aposta = 0, resultado = 0;
            int[,] folha = new int[13, 4];
            int[,] gabarito = new int[13, 4];
            Random random = new Random();

            Console.WriteLine("Quadro de apostas: \n 1- Vitória do Time 1 \n 2- Empate \n 3- Vitória do Time 2");
            //Lendo matriz de apostas
            for(int i = 0; i < 13; i++){
                Console.WriteLine($"Informe a aposta do jogo {i+1}");
                folha[i,0] = i+1;
                aposta = Convert.ToInt32(Console.ReadLine());
                switch (aposta){
                        case 1:
                            folha[i, 1] = 1;
                            folha[i, 2] = 0;
                            folha[i, 3] = 0;
                            break;
                        case 2:
                            folha[i, 1] = 0;
                            folha[i, 2] = 1;
                            folha[i, 3] = 0;
                            break;
                        case 3:
                            folha[i, 1] = 0;
                            folha[i, 2] = 0;
                            folha[i, 3] = 1;
                            break;
                        default:
                            folha[i, 1] = 0;
                            folha[i, 2] = 0;
                            folha[i, 3] = 0;
                            break;
                    }  
             }
            //Lendo matriz de resultados
            Console.WriteLine("Calculando resultados da partida...");
            for (int i = 0;  i < 13; i++) {
                resultado = random.Next(1, 4);
                gabarito[i,0] = i+1;
                switch (resultado)
                {
                    case 1:
                        gabarito[i, 1] = 1;
                        gabarito[i, 2] = 0;
                        gabarito[i, 3] = 0;
                        break;
                    case 2:
                        gabarito[i, 1] = 0;
                        gabarito[i, 2] = 1;
                        gabarito[i, 3] = 0;
                        break;
                    case 3:
                        gabarito[i, 1] = 0;
                        gabarito[i, 2] = 0;
                        gabarito[i, 3] = 1;
                        break;
                    default:
                        gabarito[i, 1] = 0;
                        gabarito[i, 2] = 0;
                        gabarito[i, 3] = 0;
                        break;
                }
            }

            for (int i = 0; i < 13; i++){
                for (int j = 0; j < 4; j++){
                    if ((folha[i, j] != gabarito[i,j]) && (gabarito[i,j] == 1)) {
                        pontos--;
                    }
                }
            }
            Console.WriteLine("\nFolha de apostas:\n");
            mostrarMatriz(folha);
            Console.WriteLine("\nFolha de resultados:\n");
            mostrarMatriz(gabarito);
            Console.WriteLine($"\n O jogador fez {pontos} pontos");
            */
        }
    }
}