using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Exercicios.ClasseEMetodosCSharp.Modelos;
using ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos;

namespace ScreenSound.Exercicios
{
    public class MainExercicios
    {
        public MainExercicios()
        {
            /* Classe e Métodos no C#
             * 1 - Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
             * 2 - Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, 
             * utilizando interpolação de strings.
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
             *     
             * Integrando Classes e Definindo Relacionamentos 
             * 1 - Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, 
             * como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de 
             * forma detalhada.
             * 2 - Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, 
             * a partir da Conta.
             * 3 - Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar 
             * novos produtos, e exibir todos os produtos no estoque.
             * 4 - Modelar o sistema de uma escola. 
             *     Crie classes para:
             *     * Aluno 
             *     * Professor
             *     * Disciplina
             * A classe Aluno deve ter informações como nome, idade e notas. 
             * A classe Professor deve ter informações sobre nome e disciplinas lecionadas. 
             * A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
             * Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. 
             * A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. 
             * Os pedidos podem estar associados a uma mesa.
             */

            Titular kelvin = new Titular("Kelvin");
            Conta contaKelvin = new Conta(12345, 777);
            contaKelvin.Titular = kelvin;

            contaKelvin.ExibirDetalhesConta();




        }

    }
}