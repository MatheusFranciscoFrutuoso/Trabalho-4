using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    class CategoriaRepository
    {
        private List<Categoria> ListaCategorias { get; set; }
        public CategoriaRepository()
        {
            ListaCategorias = new List<Categoria>();
        }

        public void Create(Categoria model)
        {
            ListaCategorias.Add(model);
        }
        public List<Categoria> ReadAll()
        {
            return this.ListaCategorias;
        }
    }
}
