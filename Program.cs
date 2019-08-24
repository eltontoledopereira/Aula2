using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
        
        float altura, peso, imc;

            Console.WriteLine("Digite o seu peso");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            altura = float.Parse(Console.ReadLine());

            imc = CalcularIMC (altura, peso);

            ExibirIMC(imc);
         
            Console.ReadLine();

        }
        private static float CalcularIMC (float altura, float peso)
        {
            return peso / (altura * altura);
        }

        private static void ExibirIMC(float imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal");
            }
            else if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine("Sobrepeso");
            }
            else if ((imc >= 30) && (imc < 40))
            {
                Console.WriteLine("Obesidade");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grave");
            }
        }
           
    }
}
