using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual time ganhou a copa?");
            string[] times = new string[4];
            times[0] = "brasil";
            times[1] = "franca";
            times[2] = "mexico";
            times[3] = "alemanha";


            for (int i = 0; i < 4; i++)
                Console.WriteLine($"{i} - {times[i]}");

            int tentativas = EhVencedor(1);

            if (tentativas == 0)
                Console.WriteLine($"Parabéns, você acertou de primeira!");
            else
                Console.WriteLine($"Parabéns, você acertou! Mas errou {tentativas} vezes");

            Console.ReadLine();
            
        }

        private static int EhVencedor(int vencedor)
        {

            bool acertou = false;
            int acumulador = 0;
            while (acertou == false)
            {
                Console.WriteLine("Digite o indice: ");

                string opcaoDoUsuarioEmTexto = Console.ReadLine();
                int opcaoDoUsuario = Convert.ToInt32(opcaoDoUsuarioEmTexto);

                if (opcaoDoUsuario == vencedor)
                {
                    acertou = true;
                }
                else
                {
                    /*acumulador = acumulador + 1;
                     */
                    acumulador++;
                    Console.WriteLine("Errou");
                }
           
            }
            return acumulador;
        }
           
    }
}
