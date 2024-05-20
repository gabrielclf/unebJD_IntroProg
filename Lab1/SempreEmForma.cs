using System;

namespace LaboratorioUm
{
    public class Pessoa
    {
        
        /*TODO - Requisitos*/
        private int Peso ;
        private double Altura ;
        private string Nome;
        /*TODO - Construtor*/
        public Pessoa (int peso, double altura,string nome){
            Peso = peso;
            Altura = altura;
            Nome = nome;
        }
        /*TODO - Métodos*/


        public double calcularIMC(){
            double imc = Peso/(Altura*Altura);
            return imc;
        }

        public string avaliacaoFisica(){
            double imc = calcularIMC();
            string avaliacao = "";

            if (imc < 18.5){
                avaliacao = "BAIXO";
            } else if ((imc <= 18.5)&&(imc<25)) {
                avaliacao = "NORMAL";
            } else if (imc >=25){
                avaliacao = "ALTO";
            }
            return avaliacao;
        }
        public int getPeso(){
            return this.Peso;
        }
        public void setPeso(int peso){
            this.Peso = peso;
        }
        public double getAltura(){
            return this.Altura;
        }
        public void setAltura(double altura){
            this.Altura = altura;
        }
        public string getNome(){
            return this.Nome;
        }
        public void setNome(string nome){
            this.Nome = nome;
        }
        public void aumentarPeso(int n){
            Peso += n;
        }

        public void diminuirPeso(int n){
            Peso -= n;
        }

        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(62,1.55,"Numero_1");
            double imc = p1.calcularIMC();
            /*Console.WriteLine($"IMC da pessoa é: {imc}");
            Console.WriteLine($"O peso da pessoa é {p1.Peso} Kg");
            Console.WriteLine($"A altura da pessoa é {p1.Altura} m");
            Console.WriteLine($"O nome da pessoa é {p1.Nome} "); */

            Console.WriteLine("Informe o nome da pessoa");
            string n = Console.ReadLine();
            p1.setNome(n);
            Console.WriteLine("Informe o peso da pessoa");
            int pe = Convert.ToInt32(Console.ReadLine());
            p1.setPeso(pe);
            Console.WriteLine("Informe a altura da pessoa");
            double alt = Convert.ToDouble(Console.ReadLine());
            p1.setAltura(alt);

            Console.WriteLine($"IMC da pessoa é: {imc}");
            Console.WriteLine($"O peso da pessoa é {p1.Peso} Kg");
            Console.WriteLine($"A altura da pessoa é {p1.Altura} m");
            Console.WriteLine($"O nome da pessoa é {p1.Nome} ");
            
            //Pessoa p2 = new Pessoa(pe,alt,n);
            /*string resultado_forma = p2.avaliacaoFisica();
            Console.WriteLine($"O resultado da avaliação física é de IMC: {resultado_forma}");*/

            


        }/*main*/

    }/*class Pessoa*/

}/*namespace*/