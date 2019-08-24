using System;
using System.Collections.Generic;

namespace MeusExercícios
{
    class Program
    {
        private static Dictionary<int, string> _operacoes = new Dictionary<int, string>
        {
                { 0, "Soma" },
                { 1, "Subtracao" },
                { 2, "Multiplicacao" },
                { 3, "Dvisao" },
                { 4, "Sair" }
        };
        static void Main(string[] args)
        {
            Menu();

            bool aberto = true;
            while (aberto)
            {
                Console.WriteLine("Digite uma operacao: ");
                decimal operacao = LeiaNumero();

                //if (operacao == 4)

                switch (operacao)
                {
                    case 0:
                        Soma();
                        break;
                    case 1:
                        Subtracao();
                        break;
                    case 2:
                        Multiplicacao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        aberto = false;
                        break;
                    default:
                        Console.WriteLine("Este numero nao esta no menu");
                        break;
                }   
            }


        }

        private static decimal PedeNumero()
        {
            Console.WriteLine("Digite um numero: ");
            return LeiaNumero();
        }

        private static void Divisao()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            decimal resultado = Cálculos.Divisao(num1, num2);
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }

        private static void Multiplicacao()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            decimal resultado = Cálculos.Multiplicacao(num1, num2);
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }

        private static void Subtracao()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            decimal resultado = Cálculos.Subtracao(num1, num2);
            Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
        }

        private static void Soma()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            decimal resultado = Cálculos.Soma(num1, num2);
            Console.WriteLine($"O resultado da soma é: {num1 + num2}");
        }

        private static void Menu()
        {
            foreach (var operacao in _operacoes)
                Console.WriteLine($"{operacao.Key} - {operacao.Value}");
        }

        private static decimal LeiaNumero()
        {
            string txt = Console.ReadLine();
            return Convert.ToInt32(txt);
        }
    }
}
