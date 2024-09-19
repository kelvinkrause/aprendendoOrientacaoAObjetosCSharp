using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos
{
    public class Cardapio
    {
        private List<Prato> pratos = new List<Prato>();

        public void CadastrarPratos(Prato prato) => pratos.Add(prato);

        public void ExibirCardápio()
        {
            foreach (Prato prato in pratos)
            {
                Console.WriteLine($"{pratos.IndexOf(prato) + 1} - {prato.Nome.ToUpper()}");
                Console.WriteLine($"    {prato.Ingredientes}");
            }
        }
    }
}
