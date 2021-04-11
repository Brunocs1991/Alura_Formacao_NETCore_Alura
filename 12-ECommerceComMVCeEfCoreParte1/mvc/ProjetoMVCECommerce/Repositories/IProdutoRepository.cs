using ProjetoMVCECommerce.Models;
using System.Collections.Generic;

namespace ProjetoMVCECommerce.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}