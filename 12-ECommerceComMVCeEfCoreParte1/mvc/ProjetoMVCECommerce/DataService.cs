using Newtonsoft.Json;
using ProjetoMVCECommerce.Models;
using ProjetoMVCECommerce.Repositories;
using System.Collections.Generic;
using System.IO;

namespace ProjetoMVCECommerce
{
    class DataService : IDataService
    {
        private readonly ApplicationContex contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContex contexto, IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }
        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();
            List<Livro> livros = GetLivros();
            produtoRepository.SaveProdutos(livros);
        }
        
        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json ");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
    
}
