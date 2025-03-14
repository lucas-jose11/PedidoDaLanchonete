
namespace PedidoDaLanchonete
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }

        public List<Produto> Produtos { get; set; } 

        public Pedido(int numeroPedido, List<Produto> produtos)
        {
            NumeroPedido = numeroPedido; 
            Produtos = produtos; 
        }
    }
}