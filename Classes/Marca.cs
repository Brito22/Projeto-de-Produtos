using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Marca : IMarca
    {
        private int CodigoMarca { get; set; }
        
        private string NomeMarca { get; set; }
        
        private string DataCadastroMarca { get; set; }

        public Marca(int codigomarca, string nomemarca, string datacadastromarca)
        {
            CodigoMarca = codigomarca;
            NomeMarca = nomemarca;
            DataCadastroMarca = datacadastromarca;
        }

        public Marca()
        {
        }

        List<Marca> marca = new List<Marca>();
        public string CadastrarMarca()
        {
            Console.WriteLine("Qual a marca do produto cadastrado?");
            NomeMarca = Console.ReadLine();

            return "Marca Cadastrada com sucesso";
        }
         public void AdicionarProduto()
        {
            marca.Add(new Marca());
        }

        public void ListarMarca()
        {
            foreach (var item in marca)
            {
                Console.WriteLine($"{CodigoMarca} - {NomeMarca} - {DataCadastroMarca}");
            }
        }
        public string DeletarMarca()
        {
            marca.Remove(new Marca());
            return "Marca Deletada";
        }
    }
}