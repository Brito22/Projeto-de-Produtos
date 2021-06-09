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

        private bool Logado { get; set; }

        public string Deslogar()
        {
            Logado = true;
            return"Usuario deslogado";
        }

        public string Logar()
        {  

            if (Logado == false )
            {
            Console.WriteLine("Qual o seu email para login?");
            validacaoEmail = Console.ReadLine();
            
            Console.WriteLine("Qual a sua Senha para login?");
            validacaoSenha = Console.ReadLine();
                return"Login realizado com sucesso";

            } else{
                return"Login não realizado, favor verificar os dados";
            }
        }

        void ILogin.Login(bool Logado)
        {
            do
        {
            if (Email == validacaoEmail && Senha == validacaoSenha)
            {
                Logado = false;
                Console.WriteLine($"{Logado}");

            } else
            {
                Logado = true;
                loginVerificação = false;
                Console.WriteLine($"{Logado}");

            }
            
        } while (Logado == true);
        }
    }
}