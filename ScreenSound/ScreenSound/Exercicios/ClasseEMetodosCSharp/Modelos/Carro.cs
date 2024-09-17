using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.ClasseEMetodosCSharp.Modelos
{
    public class Carro
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int anoFabricacao { get; set; }


        public void Acelerar() =>
            Console.WriteLine("Carro Acelerou.");
        public void Frear() =>
            Console.WriteLine("Carro Freou.");
        public void Buzinar() =>
            Console.WriteLine("BI BI BI");

        public string DescricaoDetalhada =>
            $"Carro: {Fabricante} {Modelo} ano: {anoFabricacao}";


    }
}