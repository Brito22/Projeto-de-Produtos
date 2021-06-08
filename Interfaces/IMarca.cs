using System;
using Projeto_de_Produtos.Classes;
using System.Collections.Generic;

namespace Projeto_de_Produtos.Interfaces
{
    public interface IMarca
    {
        public string CadastrarMarca();

        public void ListarMarca();

        public string DeletarMarca();
    }
}