using System;

namespace ListaRepeticao
{
  class Program
  {
    static void Main(string[] args)
    {
      //Q1
      /*
      int a,b,soma;
      soma = 0;

      Console.WriteLine("Informe o primeiro número");
      a = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Informe o segundo número");
      b = Convert.ToInt32(Console.ReadLine());

      for(int i = a+1;i<b;i++){
        if (i % 2 != 0){
            soma += i;
            Console.WriteLine(i);
        }
      }
    
    Console.WriteLine($"A soma entre todos os números impares entre {a} e {b} é {soma}");
    */

    // Q2
    /*
    Console.WriteLine("Informe o numero para a tabuada: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe a operação para a tabuada");
    char op = Convert.ToChar(Console.ReadLine());

    switch (op){
      case '+':
        for (int i = 0; i<=10;i++){
          Console.WriteLine($"{num} + {i} = {num+i}");
        }
      break;
      
      case '-':
        for (int i = 0; i<=9;i++){
          Console.WriteLine($"{num} - {i} = {num-i}");
        }
      break;
      
      case '*':
        for (int i = 0; i<=9;i++){
          Console.WriteLine($"{num} * {i} = {num*i}");
        }
      break;

      /*case '/':
        for (int i = 0; i<=9;i++){
          Console.WriteLine($"{num} + {i} = {num+i}");
        }
      break; 

      default:
        Console.WriteLine("nope");
      break;
      
    }
    */
    
      //Q3
      /*
      int num,menor;
      Console.WriteLine("Informe os números inteiros positivos de um conjunto \n digitar '0' parar a contagem");
      num = Convert.ToInt32(Console.ReadLine());
      menor = num;
      while (num != 0){
        if (num < menor){
          menor = num;
        }

        num = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine($"O menor número inserido no conjunto foi {menor}");
  */
      //Q4
      /*double num, lista, igual = 0;
      Console.WriteLine("Informe um número: ");
      num = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Informe uma lista de números: ");
      do {
        lista = Convert.ToDouble(Console.ReadLine());
        if (lista == num){
          igual = lista;
        }
      }while (num != igual);
      */

      //Q5
      /*
      Console.WriteLine("Informe números: ");
      int nums = 0, pares=0, impares=0;

      do {
        nums = Convert.ToInt32(Console.ReadLine());
        if (nums % 2 == 0){
          pares++;
        } else {
          impares++;
        }
      }while(nums != -1);

      Console.WriteLine($"A quantidade de numeros pares é: {pares} \n e a quantidade de ímpares é: {impares}");
      */
      //Q6

      int n = Convert.ToInt32(Console.ReadLine());
      int fatorial = 0;
      
      if ((n == 0)||(n == 1)){
        fatorial = 1;
      } else {
        int i;
        for (i = 1; i <= n ; i++) {
          Console.WriteLine(i);
          fatorial = n*i;
        }
      }

      Console.WriteLine($"Fatorial de {n}! = {fatorial}");
    }
    
  }
}