using System;
using Projeto_de_Produtos.Interface;

namespace Projeto_de_Produtos.Classes
{
    public class Login : Usuario, ILogin
    {
        private string validacaoEmail;
        private string validacaoSenha;


        public bool loginVerificação = false;

        Usuario usuario = new Usuario();

        private bool Logado = false;

        public string Deslogar()
        {
            Logado = true;
            return "Usuario deslogado";
        }

        public string Logar()
        {
            do
            {
                Console.WriteLine("Qual o seu email para login?");
                validacaoEmail = Console.ReadLine();

                Console.WriteLine("Qual a sua Senha para login?");
                validacaoSenha = Console.ReadLine();

                if (Email == validacaoEmail && Senha == validacaoSenha)
                {
                    Logado = false;
                    Console.WriteLine("Login Realizado com sucesso!!!");
                }
                else
                {
                    Logado = true;
                    Console.WriteLine("Email ou Senha errada, Por Favor, Tente Novamente!!!");
                }

            } while (Logado == true);
            return "Login realizado com sucesso";

        }

        void ILogin.Login()
        {
            if (Email == validacaoEmail && Senha == validacaoSenha)
            {
                Logado = false;
            }
            else
            {
                Logado = true;
                Console.WriteLine("Email ou Senha errada, Por Favor, Tente Novamente!!!");
            }
        }
    }
}