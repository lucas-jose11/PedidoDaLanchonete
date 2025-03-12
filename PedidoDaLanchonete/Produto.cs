using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDaLanchonete
{
    public class Produto
    {

        public long Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }


        public Produto(long id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

    }

}