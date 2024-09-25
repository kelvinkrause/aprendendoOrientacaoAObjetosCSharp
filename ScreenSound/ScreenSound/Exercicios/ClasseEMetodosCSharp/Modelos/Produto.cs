using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.ClasseEMetodosCSharp.Modelos
{
    public class Produto
    {
        public string? Nome { get; set; }
        public string? Marca { get; set; }
        public int Preco_em_centavos {
            get => Preco_em_centavos;
            set
            {
                if (value < 0)
                    Preco_em_centavos = 0;
                else 
                    Preco_em_centavos = value;
            } 
        }
        public int Estoque {  
            get => Estoque;
            set
            {
                if (value < 0)
                    Estoque = 0;
                else
                    Estoque = value;
            } 
        }
    }
}
