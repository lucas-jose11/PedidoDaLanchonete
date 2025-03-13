namespace PedidoDaLanchonete
{
    public class Produto
    {
     
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)// com static n vai, pq?
        {
            Nome = nome;
            Preco = preco;
        }
    }

}