using System;

namespace Calculo_IMC {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu Nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua Idade");
            float idade = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com seu Peso");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com sua Altura");
            float altura = (float) Convert.ToDouble(Console.ReadLine());    

            Console.WriteLine( "Seu Nome: " + nome);
            Console.WriteLine( "Sua Idade: " + idade);
            Console.WriteLine( "Seu Peso: " + peso);
            Console.WriteLine( "Sua Altura: " + altura);

            float Result = peso / (altura * altura);

            if (Result < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (Result >= 18.5 && Result <= 25)
            {
                Console.WriteLine("Parabens, Você está no peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do Peso");
            }



        }
    }
}
