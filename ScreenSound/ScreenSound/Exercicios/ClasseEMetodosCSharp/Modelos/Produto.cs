using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.ClasseEMetodosCSharp.Modelos
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int preco_em_centavos {
            get => preco_em_centavos;
            set
            {
                if (value < 0)
                    preco_em_centavos = 0;
                else 
                    preco_em_centavos = value;
            } 
        }
        public int estoque {  
            get => estoque;
            set
            {
                if (value < 0)
                    estoque = 0;
                else
                    estoque = value;
            } 
        }
    }
}
