using System;
using System.Collections;

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
    /*
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

      */
      //Q7
      /*
      int n_fib = Convert.ToInt32(Console.ReadLine());
      int n1=1,n2=1,n3;
      Console.Write($"\n{n1} {n2}");
      for (int i = 1; i < n_fib; i++){
        n3 = n1+n2;
        Console.Write($" {n3}");
        n1 = n2;
        n2 = n3;
      }
      */
      //Q8
      /*
      string codigo, nome = "";
      char sexo;
      int idade,total_h = 0, total_m =0;
      double letra_b = 0, todo = 0;
      while (nome!="fim") {
        Console.WriteLine("Informe seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine("Informe seu sexo:");
        sexo = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Informe sua idade:");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe seu motivo de visita por código:");
        codigo = Console.ReadLine();

        if (codigo == "020"){
          letra_b++;
        }

        switch (sexo){
          case 'h': total_h++;
          break;

          case 'm': total_m++;
          break;

          default:
          Console.WriteLine("A questão é arcaíca, desculpa");
          break;
        }
        todo++;
      }
      double percentual = (letra_b/todo)*100;
      Console.WriteLine($"a) o percentual de indivíduos que buscavam Serviços. \n = {todo}");
      if (total_h > total_m){
        Console.WriteLine($"b) quem freqüenta mais o shopping : homens ou mulheres ? \n Homens ganham com {total_h}");
      } else if (total_h == total_m){
        Console.WriteLine($"b) quem freqüenta mais o shopping : homens ou mulheres ? \n EMPATE {total_h} homens e {total_m} mulheres");
      } else {
        Console.WriteLine($"b) quem freqüenta mais o shopping : homens ou mulheres ? \n Mulheres ganham com {total_m}");
      }
      */
    
    //Q9
    /*
    char tipo = 'a', gender='b';
    int count1 = 0, count2 = 0, count3 = 0;
    double todo = 0, bl = 0;

    while (tipo !='0'){
      switch (tipo){
        case '1': count1++; break;

        case '2': count2++; break;

        case '3': count3++; break;

        default: Console.WriteLine("Sem Categoria"); break;
      }

      if ((gender == 'M')&&(tipo == '2')){
        bl++;
      }
      if ((tipo == '1')||(tipo == '2')||(tipo == '3')){ 
        if (gender == 'M'){ 
          todo++;
        }
      }
    }
      double b = (bl/todo) * 100;
      Console.WriteLine($"Percentual de homens que lêem livros de romance =  {b}%.");

      if ((count1 > count2) && (count1 > count3)){
        Console.WriteLine("O tipo de livro mais vendido no mês é Ficção");
      } else if ((count2 > count1) && (count2 > count3)){
        Console.WriteLine("O tipo de livro mais vendido no mês é Romance");
      } else if ((count3 > count2) && (count3 > count1)) {
        Console.WriteLine("O tipo de livro mais vendido no mês é Aventura");
      }
      */
    
      //Q10
      int seg = 0, min = 0, hora = 0;

      while (true){
        seg++;
        if (min == 0){
          Console.WriteLine($"{seg}s  ");
        }
        if (seg % 60 == 0){
          min++;
          Console.WriteLine($"{min}m e {seg}s");
        }
        if (min % 60 == 0){
          hora++;
          Console.WriteLine($"{hora}h, {min}m e {seg}s");
        }
      }


    }
    
  }
}