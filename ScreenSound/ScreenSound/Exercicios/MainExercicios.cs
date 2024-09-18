using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Exercicios.ClasseEMetodosCSharp.Modelos;

namespace ScreenSound.Exercicios
{
    public class MainExercicios
    {
        public MainExercicios()
        {
            /* Classe e Métodos no C#
             * 1 - Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
             * 2 - Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
             * 3 - Desenvolver um método da classe Conta que exibe suas informações.
             * 4 - Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
             * 
             * Métodos de Acesso e Propriedades
             * 1 - Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
             * 2 - Reescrever os atributos da classe Carro, de modo que eles sejam properties, 
             *     e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
             * 3 - Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
             * 4 - Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. 
             *     Além disso, garantir que o preço e o estoque do produto sejam valores positivos e 
             *     criar uma propriedade que mostra detalhadamente as informações do produto, 
             *     para que seja usado pela equipe de vendas.
             */

            ContaCorrente conta = new ContaCorrente();
            conta.Titular = "Kelvin Krause";
            conta.ExibirDadosConta();

            Carro carro = new Carro();
            carro.AnoFabricacao = 1950;
            carro.Acelerar();
            carro.Frear();
            carro.Buzinar();

        }

    }
}