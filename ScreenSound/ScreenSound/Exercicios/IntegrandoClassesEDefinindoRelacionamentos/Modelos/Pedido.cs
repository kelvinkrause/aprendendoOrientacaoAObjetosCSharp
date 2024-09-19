using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos
{
    public class Pedido
    {
        public Prato Prato { get; set; }
        public int Quantidade { get; set; }

        public Pedido(Prato prato, int quantidade)
        {
            Prato = prato;
            Quantidade = quantidade;
        }
    }
}
