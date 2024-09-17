using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.ClasseEMetodosCSharp.Modelos
{

    public class ContaCorrente
    {
        public int Numero { get; }
        public string Titular { get; set; }
        private int Valor_em_centavos { get; }
        private string senha;

        public ContaCorrente()
        {
            this.Numero = new Random().Next(1, 100);
            Console.WriteLine($"Conta criada: {this.Numero}");
        }


        public void ExibirDadosConta()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo (R$): {Valor_em_centavos / 100}");
            Console.WriteLine("*******************************************");
        }

    }
}
