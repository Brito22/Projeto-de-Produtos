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
        public bool Verificacao = false;

        public Usuario()
        {
            Console.WriteLine($"O que voce deseja?");

            Console.WriteLine($@"| 1-Cadastrar 2- Listar 3- Deletar 4- Deslogar|");
            string opcao = Console.ReadLine();

            do
            {
                switch (opcao)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":
                        Verificacao = true;
                        break;
                    default:
                        break;
                }

            } while (Verificacao == false);

        }

        public string Cadastrar(string _nome, string _senha, string _email)
        {
            Console.WriteLine($"Qual é o seu nome?");
            Nome = _nome;
            Console.WriteLine($"Qual sua senha?");
            Senha = _senha;
            Console.WriteLine($"Qual é o seu email");
            Email = _email;


            return "Cadastro realizado com sucesso";
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