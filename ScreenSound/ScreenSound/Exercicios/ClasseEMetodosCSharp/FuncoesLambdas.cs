using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.ClasseEMetodosCSharp
{
    public class FuncoesLambdas
    {
        public FuncoesLambdas()
        {
            ListaDeNumerosPares();

            Console.WriteLine(Somar(2, 3));
        }

        void ListaDeNumerosPares()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
            numerosPares.ForEach(numero => Console.WriteLine(numero));
        }

        int Somar(int x, int y) => x + y;
        

    }
}