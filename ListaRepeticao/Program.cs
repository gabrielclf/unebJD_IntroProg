using System;

namespace ListaRepeticao
{
  class Program
  {
    static void Main(string[] args)
    {
      //Q1
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
    }
  }
}