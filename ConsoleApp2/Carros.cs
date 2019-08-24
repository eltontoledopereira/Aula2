using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Carros
    {
        public Carros(string placa) {
            Placa = placa;
        }
        public string Placa { get; }
        public string Cor { get; set; }
        public int NumeroDePortas { get; set; }

        public void Ligar()
        {
            Console.WriteLine($"O carro de placa {Placa} esta ligado");
        }
    }
}
