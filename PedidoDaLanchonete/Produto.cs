using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDaLanchonete
{
    public class Produto
    {
        public void PrintItensCardapio()
        {
            Console.WriteLine($"{Nome} || R${Preco}."); //mascarar dados "mascara"? o :0.00, tbm da certo Preco:C2, DECIMAL N PRECISA DISSO
        }

        public string Nome;
        public decimal Preco;

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}