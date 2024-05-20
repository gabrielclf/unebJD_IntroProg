using System;
using System.Collections.Generic;

/*Jogos Digitais - Introdução à Programação, atividade extra 3.
* Estudantes: Gabriel Fonseca, Felipe Morais.

*/
namespace ListaStruct
{
    internal class Program
    {   // Criando o tipo estrutura que tem as informações do contra-cheque de um funcionário.
        struct Ficha
        {
            public int n_inscricao;
            public string nome;
            public int classe;
            public int horas_normais;
            public int horas_extra;
        }
        //Criando uma função que vai criar uma entrada daquele trabalhador na lista e fazer suas operações de salário (e gera um contra cheque?).
        static void contraCheque(List<Ficha> tr, int n_ins, string nomeT, int clse, int hr_n, int hr_ex, double mult)
        {
            tr.Add(new Ficha()
            {
                n_inscricao = n_ins,
                nome = nomeT,
                classe = clse,
                horas_normais = hr_n,
                horas_extra = hr_ex
            });
            Console.WriteLine("Informe o salário/hora normal da empresa: ");
            double salario_hora_normal = Convert.ToDouble(Console.ReadLine()) * mult;

            double salario_hora_extra = (salario_hora_normal + (salario_hora_normal * 0.3));
            double salario_bruto = (salario_hora_extra * hr_ex) + (salario_hora_normal * hr_n);
            double desconto_inss = 0.11 * (salario_bruto);
            
            //Procurei o método Math.Round(x,2) para arrendondar os valores para duas números após a vírgula
            Console.WriteLine("");
            Console.WriteLine($"Número de Inscrição: {n_ins}");
            Console.WriteLine($"Nome: {nomeT}");
            Console.WriteLine($"Salário Horas Normais: R${Math.Round(salario_hora_normal, 2)}");
            Console.WriteLine($"Salário Horas Extras: R${Math.Round(salario_hora_extra, 2)}");
            Console.WriteLine($"Dedução INSS: - R${Math.Round(desconto_inss, 2)}");
            Console.WriteLine($"Salário Líquido: R${Math.Round((salario_bruto - desconto_inss), 2)}");
        }
        static void Main(string[] args)
        {
            List<Ficha> trabalhador = new List<Ficha>(); //criando o Trabalhador
            while (true)
            {
                int ins, clss, hrN, hrEX;
                string nm;
                Console.WriteLine(""); //Passando os atributos básicos do Trabalhador para fazer as operações seguintes
                Console.WriteLine("Informe o número de inscrição do trabalhador: ");
                ins = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o nome do trabalhador: ");
                nm = Console.ReadLine();
                //Aplicando a Classe do trabalhador
                Console.WriteLine("Informe a qual classe o trabalhador pertence, 1 ou 2: ");
                clss = Convert.ToInt32(Console.ReadLine());
                //Definindo os multiplicadores
                double multiplicador_classe = 1;
                switch (clss)
                {
                    case 1:
                        multiplicador_classe = 1.3;
                        break;

                    case 2:
                        multiplicador_classe = 1.9;
                        break;
                }
                Console.WriteLine("Informe a quantidade de horas normais do trabalhador: ");
                hrN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de horas extra do trabalhador: ");
                hrEX = Convert.ToInt32(Console.ReadLine());
                contraCheque(trabalhador, ins, nm, clss, hrN, hrEX, multiplicador_classe);
            }
        }
    }
}
