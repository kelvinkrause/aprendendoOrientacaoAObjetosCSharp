using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos
{
    public class Conta
    {
        public Titular Titular {  get; set; }
        public int Agencia { get; }
        public int NumeroConta { get; }
        public int SaldoEmCentavos { get; }
        public int LimiteEmCentavos { get; }

        public Conta(int numeroConta, int agencia)
        {
            this.NumeroConta = numeroConta;
            this.Agencia = agencia;
            this.LimiteEmCentavos = 100000;
            this.SaldoEmCentavos = 0;
        }

        public void ExibirDetalhesConta()
        {
            Console.WriteLine("************************************");
            Console.WriteLine($"Titular: {Titular.Nome}");
            Console.WriteLine($"Agência {Agencia} - {NumeroConta}");
            Console.WriteLine($"Saldo: {SaldoEmCentavos / 100}, Limite: {LimiteEmCentavos / 100}");
            Console.WriteLine("************************************");
        }
    }
}
