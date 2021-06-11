using System;
using Projeto_de_Produtos.Interface;

namespace Projeto_de_Produtos.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private DateTime? dataCadastro { get; set; }
        public object ListarProduto { get; private set; }
        public bool Verificacao = false;
        Produto produto = new Produto();
        public string Cadastrar()
        {
            Console.WriteLine($"Qual é o seu nome?");
            Nome = Console.ReadLine();
            Console.WriteLine($"Qual é o seu email");
            Email = Console.ReadLine();
            Console.WriteLine($"Qual sua senha?");
            Senha = Console.ReadLine();

            return "Cadastro realizado com sucesso";
        }
        public string Menu()
        {
            do
            {
            Console.WriteLine($"O que voce deseja?");

            Console.WriteLine($@"| 1-Cadastrar 2- Listar 3- Deletar 4- Deslogar |");
            string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        produto.CadastrarProduto();
                        break;
                    case "2":
                        produto.ListarProduto();
                        break;
                    case "3":
                        produto.DeletarProduto();
                        break;
                    case "4":
                        Verificacao = true;
                        break;
                    default:
                    Console.WriteLine("Valor Invalido, Por Favor, Tente Novamente!!!");
                        break;
                }

            } while (Verificacao == false);
            return"O que deseja?";
        }
        public string Deletar()
        {
            Nome = null;
            Codigo = 0;
            Senha = null;
            dataCadastro = null;

            return "Usuario deletado";
        }
    }
}