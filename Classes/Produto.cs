using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Produto : IProduto
    {
        List<Produto> produto = new List<Produto>();
        private int CodigoProduto { get; set; }

        private string NomeProduto { get; set; }

        private float Preco { get; set; }

        private int DataCadastroProduto { get; set; }
        Marca marca = new Marca();

        //Usuario CadastradoPor = new Usuario();
   
        public string CadastrarProduto()
        {
            Console.WriteLine("Qual o nome do produto?");
            NomeProduto = Console.ReadLine();

            Console.WriteLine("Qual o codigo do produto?");
            CodigoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome do produto?");
            Preco = float.Parse(Console.ReadLine());

            DateTime DataCadastroProduto = DateTime.Now;

            return "Produto Cadastrado com sucesso";
        }

        public void AdicionarProduto()
        {
            produto.Add(new Produto());
        }

        public string DeletarProduto()
        {
            produto.Remove(new Produto());
            return "Produto Deletado";
        }

        public void ListarProduto()
        {
            foreach (var item in produto)
            {
                Console.WriteLine($" {marca} - {CodigoProduto} - {NomeProduto} - {Preco:C2} - {DataCadastroProduto}");
            }
        }
    }
}