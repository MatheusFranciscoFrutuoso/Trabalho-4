using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Produto : BaseModel
    {
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public Produto(int id, string nome, string descricao, decimal valor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
