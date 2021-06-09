using Projeto_de_Produtos.Interface;

namespace Projeto_de_Produtos.Classes
{
    public class Login : ILogin
    {
        private string validacaoEmail;
        private string validacaoSenha;
        Usuario us = new Usuario();

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
                return"Login realizado com sucesso";

            } else{
                return"Login não realizado, favor verificar os dados";
            }
        }

        void ILogin.Login(bool Logado)
        {
            if (validacaoEmail == us.Email && validacaoSenha == us.Senha)
            {
                Logado = false;

            } else
            {
                Logado = true;
            }
        }
    }
}