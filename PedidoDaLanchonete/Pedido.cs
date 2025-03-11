using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDaLanchonete
{
    public class Pedido
    {

        public int NumeroPedido { get; set; }
        public List<Produto> Produtos {  get; set; } // um pedido pode ter vários produtor

        // produtos -> lista de objetos
        //Produto -> variavel criada, não padrao
        //
        
        public Pedido(int numeroPedido)
        {
            NumeroPedido = numeroPedido; //define o number do pedido
            Produtos = new List<Produto>(); //inicializa o troço da lista de produtos
        }

        public decimal SomaPedido(IList<Produto> produtos)
        {
            decimal totalPedido = 0;
            foreach (Produto item in produtos) 
            {
                totalPedido += item.Preco; // ai deu um tchugas e pegou apenas a propriedade preço do item, que é o nome que eu resolvi chaamr dentro do foreach, podia ser produto
            }
            return totalPedido;
        }

    }

}