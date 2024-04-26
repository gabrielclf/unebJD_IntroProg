using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ListaRepeticao {
  class Program {
    static void Main(string[] args){ 
        /*
        * Questão 1: Fazer um algoritmo que leia um vetor com 8 elementos, e imprima a
          multiplicação dos elementos lidos.
        
        int[] elementos = new int[8];
        int produto = 1;
        for (int i = 0; i<8;i++){
             elementos[i] = Convert.ToInt32(Console.ReadLine());
             produto *= elementos[i];
        }

        Console.WriteLine($"O produto dos 8 elementos inseridos no vetor é: {produto}");
        */

        /* Q1 - ALT
        int [] elementos = {1,2,3,4,5,6,7,9};
        int produto = 1;
        foreach (int i in elementos){
            produto*=i;
        }
        Console.WriteLine($"O produto dos 8 elementos inseridos no vetor é: {produto}");
        */

        /*
        *Questão 2:Fazer um algoritmo que leia dois vetores A e B de 8 elementos cada
         um e calcula um terceiro vetor C, cujos elementos são resultado da soma dos
         elementos correspondentes de A e B.
        
            //declaração de multiplos vetores do mesmo tamanho ao mesmo tempo
            int[] a,b,c = new int[8];
            a = [1,2,3,4,5,6,7,8];
            b = [9,10,11,12,13,14,15,16];
            for (int i = 0; i<8; i++){
                c[i] = a[i]+b[i];
                Console.WriteLine(c[i]);
            }
            */
        
        
        /*
        * Questão 3: Uma empresa precisa realizar uma estatística do salário de seus
        funcionários. Para isto precisa de um programa que leia uma lista contendo os
        salários dos funcionários da empresa, e imprima quantos funcionários ganham
        salário acima da média. Sabe-se que a empresa possui 50 funcionários.
        
        Console.WriteLine("Informe a média salarial: ");
        double media_salarial = Convert.ToDouble(Console.ReadLine());
        double[] salar_func = new double[5];
        int acima = 0;
        Console.WriteLine("Informe o salário do funcionário(s): ");
        for(int i = 0; i < salar_func.Length; i++){
            salar_func[i] = Convert.ToDouble(Console.ReadLine());     
            if (salar_func[i] > media_salarial){
                acima++;
            }
        }
        Console.WriteLine($"{acima} funcionario(s) possuem salários acima da média.");
           */

        /*
        * Questão 4: Leia dois vetores VET1 e VET2, ambos com 10 elementos cada, sendo
        que só devem ser aceitos valores em ordem crescente. Após gere e imprima o
        vetor VET3, resultado da intercalação de VET1 e VET2.
         
        
        int[] vet1 = new int[3];
        int[] vet2 = new int[3];
        int[] vet3 = new int [(vet1.Length+vet2.Length)];
        Console.WriteLine("Inserindo elementos de vet1: "+vet3.Length);
        int i = 0;
        while (i<vet1.Length){
            int numero = Convert.ToInt32(Console.ReadLine());
            if (i == 0) {
                vet1[i] = numero;
                i++;
            }
            if (i>=1){
                if (numero > vet1[i-1]){
                    vet1[i] = numero;
                    i++;
                }
            }
        }

        Console.WriteLine("Inserindo elementos de vet2: ");
        int j = 0;
        while (j<vet2.Length){
            int numero = Convert.ToInt32(Console.ReadLine());
            if (j == 0) {
                vet2[j] = numero;
                j++;
            }
            if (j>=1){
                if (numero > vet2[j-1]){
                    vet2[j] = numero;
                    j++;
                }
            }
        }

        for (int k = 0; k<vet3.Length;k++){
            if (k > (vet3.Length/2)-1){
                vet3[k] = vet2[vet3.Length%k];
            } else {
                vet3[k]=vet1[k];
            }
        }
        Array.Sort(vet3);
        Console.WriteLine("Elementos de V3: ");

        for (int k = 0; k<vet3.Length;k++){
            Console.WriteLine(vet3[k]);
        }
       */

       /*
       * Questão 5: Faça um programa que leia um vetor de 10 posições e um valor N.
        Após pesquise se existe o valor N no vetor lido. Se o valor for encontrado, deve
        ser impressa a posição do numero no vetor (Índice). Se o valor não foi
        encontrado, deve ser impressa uma mensagem.
       
       int[] ve = new int[10];
       int n;
       Random rnd = new Random(); 

       for (int i = 0; i<ve.Length;i++) {
            ve[i] = rnd.Next(1,10);
       }
        Console.WriteLine("Lendo N: ");
        n = Convert.ToInt32(Console.ReadLine());
        string achou = "Não foi encontrado";
       for (int i = 0; i<ve.Length;i++){
        if (ve[i] == n)        {
            achou = $"Achado na posição {i}";
        }
       }
       Console.WriteLine(achou);
       */ 

       /*
       * Questão 6: Faça um programa para ler uma sequência de até 10 números
        inteiros e positivos, e armazená-los em um vetor. Em seguida deve ser gerado um
        segundo vetor contendo todos os elementos da sequência lida, sem repetições.
        No final, o algoritmo deverá imprimir as duas sequências.
       
       int[] seq = new int[5];
       int leitor;
       
       for (int i = 0; i<seq.Length;i++){
            Console.WriteLine($"Preencha o vetor com mais {seq.Length-i} numeros");
            leitor = Convert.ToInt32(Console.ReadLine());
            seq[i] = leitor;
       }

        int[] seq2 = []; //array dinâmico
        int repetido = seq[0];
        seq2[0] = seq[0];
        for (int i = 0; i<seq.Length;i++){
            int j = 1;
            if (seq[i] == repetido){
                repetido = seq[i];
            } else {
                seq2[j] = seq[i];
                j++;
            }
       }

        for (int i = 0; i<seq.Length;i++){
            Console.WriteLine($"Sequencia 1 pos[{i}] = {seq[i]}");
        }

        for (int i = 0; i<seq2.Length;i++){
            Console.WriteLine($"Sequencia 2 pos[{i}] = {seq2[i]}");
        }
        */

        /*
        *Questão 7: Escrever um programa que leia os elementos (números inteiros) de
uma matriz M(3,5). O programa a seguir deve ler um número inteiro X e procura
este elemento na matriz M. Se o elemento for encontrado, imprimir a linha e a
coluna (posição do elemento na matriz), caso contrário imprimir “Elemento não
encontrado”.
        

        int[,] matrix = new int[3,5];
        Random rnd = new Random(); 
        Console.WriteLine("Leia X:");
        int x = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 5; j++){
                    matrix[i, j] = rnd.Next(1,10); 
            }
        }
        Console.WriteLine("Matriz: ");
        for(int i = 0; i < 3; i++){
         for(int j = 0; j < 5; j++){
            Console.Write("{0}\t", matrix[i, j]);  
         }
       Console.Write("\n");
      }

        for(int i = 0; i < 3; i++){
            for (int j = 0; j<5; j++){
                if (matrix[i,j] == x ){
                    Console.WriteLine($"X encontrado na Linha {i+1} e Coluna {j+1}");
                } else if ((i==2 && j ==4) && (matrix[i,j]!=x)){
                    Console.WriteLine("Elemento não encontrado");
                }
            }
        }
        */

        /*
        * Questão 8
        

        int voto;
        int[] urna = new int[10];
        bool eleicao = true;
        Console.WriteLine("Vote no seu candidato informando um numero de 1 a 10");

        while (eleicao){
            voto = Convert.ToInt32(Console.ReadLine());
            switch (voto){
                case 1:
                    eleicao = true;
                    urna[0] +=1;
                break;

                case 2:
                    eleicao = true;
                    urna[1] +=1;
                break;

                case 3:
                    eleicao = true;
                    urna[2] +=1;
                break;

                case 4:
                    eleicao = true;
                    urna[3] +=1;
                break;

                case 5:
                    eleicao = true;
                    urna[4] +=1;
                break;

                case 6:
                    eleicao = true;
                    urna[5] +=1;
                break;

                case 7:
                    eleicao = true;
                    urna[6] +=1;
                break;

                case 8:
                    eleicao = true;
                    urna[7] +=1;
                break;

                case 9:
                    eleicao = true;
                    urna[8] +=1;
                break;

                case 10:
                    eleicao = true;
                    urna[9] +=1;
                break;

                default:
                    Console.WriteLine("Começar a contagem de votos...");
                    eleicao = false;
                break;
            }
        }
        Console.WriteLine("Lista dos Resultados finais: \n");

        int maior = 0 , num_maior = 0;
        
        for (int i = 0; i < 10 ; i++){
            Console.WriteLine($"Candidato número {i+1} \t Numero de votos: {urna[i]}");
            if (urna[i] > maior){
                maior = urna[i];
                num_maior = i+1;
            }
            if (i == 9){
                Console.WriteLine($"O candidato mais votado foi o número {num_maior} com {maior} votos");
            }
        }  
        */

         /*
         * Questão 9
         
        int[] seq1 = []; int[] seq2 = []; int[] seq3 = []; 
        int[] aux = new int[10];
        int n, i = 0;

        Console.WriteLine("Declarando Sequência A: ");

        do{  
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 999){
                continue;
            }
            aux[i] = n;
            i++;
        }while((n > 0)&&(n!=999));

        for (int k = 0; k<10;k++){
            if (aux[k]!=0){
                seq1[k] = aux[k];
            }
        }

        Console.WriteLine("Declarando Sequência B: ");
        i = 0;

        do{  
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 999){
                continue;
            }
            aux[i] = n;
            i++;
        }while((n > 0)&&(n!=999));

        for (int k = 0; k<10;k++){
            if (aux[k]!=0){
                seq2[k] = aux[k];
            }
        }
        //Sequencia C: Intersecção
        int comparar;
        for (int j = 0; j<10;j++){
            for( int l = 0; l<10;l++){
                comparar = seq1[j];
                if (comparar == seq2[l]){
                    seq3[l] = comparar;
                }
            }
        }
       
        //Seq D: União
        int[] seq4 = [];

        */

        /*
        * Questão 10: Escrever um programa que leia os elementos (números inteiros e
        positivos) de uma matriz Z(3,4) calcule e imprima o maior e o menor elemento
        desta matriz, seguido da posição em que eles se encontram.
        

        int ele, maior = 0, menor = 0, linha_maior = 0, linha_menor = 0, coluna_maior = 0, coluna_menor = 0;
        int[,] matriz = new int[3,4];
        menor = matriz[0,0];

        for (int a = 0; a < 3; a++){
            for (int b = 0; b < 4; b++){
                ele = Convert.ToInt32(Console.ReadLine());
                matriz[a,b] = ele;
                if (ele > maior){
                    maior = matriz[a,b];
                    linha_maior = a;
                    coluna_maior = b;
                }
                if (ele < menor){
                    menor = matriz[a,b];
                    linha_menor = a;
                    coluna_menor = b;
                }
                //após o ultimo elemento da matriz ser inserido
                if ((a == 2) && (b==3)){
                    Console.WriteLine($"Maior elemento da Matriz Z(3,4) = {maior} e está localizado em {linha_maior}x{coluna_maior} \n Menor elemento da Matriz Z(3,4) = {menor} e está localizado em {linha_menor}x{coluna_menor}");
                }

            }
        }
        */

        /*
        Questão 11: Escrever um programa C que leia uma matriz A de 4 linhas e 4
        colunas. A seguir este programa deverá calcular a soma dos elementos da sua
        diagonal principal e mostrar o resultado.
        */

        int[,] matrix = new int[4,4];
        Random rand = new Random();
        int soma_diagonal = 0;

        for (int a = 0; a < matrix.Length;a++){
            for (int b = 0; b < matrix.Length;b++){
                matrix[a,b] = rand.Next(0,10);
                if (a==b){
                    soma_diagonal += matrix[a,b];
                }
            }
        }
        Console.WriteLine($"A soma dos elementos da diagonal principal é: {soma_diagonal}");


       }
    }
 }

