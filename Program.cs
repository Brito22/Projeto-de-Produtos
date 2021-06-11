using System;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            Usuario menu  = new Usuario();
            Produto produto = new Produto();

            login.Cadastrar();
            login.Logar();
            login.Menu();
        }
    }
}
