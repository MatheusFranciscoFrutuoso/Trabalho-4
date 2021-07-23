using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    class ProdutoRepository
    {
        private List<Produto> ListaProdutos { get; set; }
        public ProdutoRepository()
        {
            ListaProdutos = new List<Produto>();
        }

        public void Create(Produto model)
        {
            ListaProdutos.Add(model)
        }
        public List<Produto> ReadAll()
        {
            return this.ListaProdutos;
        }
    }
}
