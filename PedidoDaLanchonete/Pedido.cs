using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        public Pedido(int numeroPedido, List<Produto> produtos)
        {
            NumeroPedido = numeroPedido; //define o number do pedido
            Produtos = produtos; //inicializa o troço da lista de produtos
        }

    }

}