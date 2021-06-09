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

        private string nomemarca;

        private DateTime DataCadastroProduto { get; set; }
        Marca marca = new Marca();

        //Usuario CadastradoPor = new Usuario();

        Marca marcaproduto = new Marca();

        public string CadastrarProduto()
        {
            
            bool veri = false;
            string resposta = "n";
            do
            {
                Console.WriteLine("Qual o nome do produto?");
                NomeProduto = Console.ReadLine();

                Console.WriteLine("Qual o codigo do produto?");
                CodigoProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o Preço do produto?");
                Preco = float.Parse(Console.ReadLine());

                Console.WriteLine("Qual a marca do produto cadastrado?");
                nomemarca = Console.ReadLine();

                DateTime DataCadastroProduto = DateTime.Now;

                produto.Add(new Produto());

                Console.WriteLine($"Deseja Cadastrar mais um produto");
                resposta = Console.ReadLine().ToLower();


                if (resposta == "n")
                {
                    veri = true;

                }

            } while (veri != true);

            return "Produto Cadastrado com sucesso";
        }

        public void AdicionarProduto()
        {
            produto.Add(new Produto());
        }

        public string DeletarProduto()
        {
            //produto.RemoveAll(new Produto);
            return "Ultimo produto Deletado";
        }

        public void ListarProduto()
        {
            foreach (var item in produto)
            {
                Console.WriteLine($" {nomemarca} - {CodigoProduto} - {NomeProduto} - {Preco:C2} - {DataCadastroProduto}");
            }
        }
    }
}