using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interfaces
{
    public interface IProduto
    {
        public string CadastrarProduto();
         
        public void ListarProduto();

        public string DeletarProduto();
    }
}