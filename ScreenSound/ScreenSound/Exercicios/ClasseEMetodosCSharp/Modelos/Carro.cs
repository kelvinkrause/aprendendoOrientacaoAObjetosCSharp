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
        public int AnoFabricacao { 
            get => AnoFabricacao; 
            set
            {
                if(value < 1960 ||  value > 2023)
                {
                    Console.WriteLine("Ano Fabricação deve ser entre os anos 1960 e 2023");
                }
                else
                {
                    AnoFabricacao = value;
                }
            } 
        }


        public void Acelerar() =>
            Console.WriteLine("Carro Acelerou.");
        public void Frear() =>
            Console.WriteLine("Carro Freou.");
        public void Buzinar() =>
            Console.WriteLine("BI BI BI");

        public string DescricaoDetalhada =>
            $"Carro: {Fabricante} {Modelo} ano: {AnoFabricacao}";


    }
}