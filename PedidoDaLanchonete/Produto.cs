
namespace PedidoDaLanchonete
{
    public class Produto
    {
        public string Nome { get; set; }

        public string Preco { get; set; }

        public Produto(string nome, string preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

}