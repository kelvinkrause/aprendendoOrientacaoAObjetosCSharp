using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos
{
    public class Mesa
    {
        public int numero {  get; set; }

        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
        public Mesa(int numero) => this.numero = numero;

    }
}
