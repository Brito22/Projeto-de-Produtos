using System;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interface
{
    public interface IUsuario
    {
      string Cadastrar(string _nome, string _senha, string _emails);
      string Deletar(); 

    }
}