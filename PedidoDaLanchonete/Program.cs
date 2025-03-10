namespace PedidoDaLanchonete
{
    public class Program
    {
        //public List<Produto> cardapio = new List<Produto>(); pq é calsse

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a Lanchonete Da Silva!");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("De uma olhada em nosso cardápio, digite os números dos itens que você deseja e digite 0 quando estiver acabado com o pedido.");

            List<Produto> cardapio = new List<Produto>();

            //Produto x_Burger = new Produto { Nome = "X-Burger", Preco = 35.00}; se n tivesse construtor
            //x_Burger.Nome = "X-Burger"; ou assim
            //x_Burger.Preco = 35.00;
            Produto x_Burger = new Produto("Hambúrguer", 35.00m);
            cardapio.Add(x_Burger);

            Produto x_Calota = new Produto("X-Calota", 55.75m);
            cardapio.Add(x_Calota);

            Produto x_Salada = new Produto("X-Salada", 14.00m);
            cardapio.Add(x_Salada);

            Produto batataFrita = new Produto("Batata Frita", 16.83m);
            cardapio.Add(batataFrita);

            Produto chickenNuggets = new Produto("Pacote com 12 chicken nuggets", 25.99m);
            cardapio.Add(chickenNuggets);

            Produto agua = new Produto("Água da casa: Álgua", 4.99m);
            cardapio.Add(agua);

            Produto refrigerante = new Produto("Refrigerante", 8.00m);
            cardapio.Add(refrigerante);


            foreach (var produto in cardapio)
            {
                produto.PrintItensCardapio();
            }

            Console.WriteLine("");

            //--------------------------
            //----------------------------
            Pedido pedido_1 = new Pedido(1); //o 1 pq fiz o metodo que pega esse int e trasnforma no valor do NumeroPedido
            pedido_1.Produtos.Add(x_Salada);
            pedido_1.Produtos.Add(batataFrita);
            pedido_1.Produtos.Add(agua);


            Console.WriteLine("Detalhes do Pedido #1:");
            Console.WriteLine("=======================");

            Console.WriteLine($"Pedido #{pedido_1.NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach (var item in pedido_1.Produtos)
            {
                Console.WriteLine($"- {item.Nome} - R${item.Preco}");
            }
            Console.WriteLine("------------");
            Console.WriteLine($"Total a pagar: R${pedido_1.SomaPedido(pedido_1.Produtos):F2}");
            Console.WriteLine("=======================");


            Console.WriteLine("\n\n\n");

            //------------------
            //-------------------
            Pedido pedido_2 = new Pedido(2); //o 1 pq fiz o metodo que pega esse int e trasnforma no valor do NumeroPedido
            pedido_2.Produtos.Add(x_Calota);
            pedido_2.Produtos.Add(chickenNuggets);
            pedido_2.Produtos.Add(refrigerante);


            Console.WriteLine("Detalhes do Pedido #2:");
            Console.WriteLine("=======================");

            Console.WriteLine($"Pedido #{pedido_2.NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach (var item in pedido_2.Produtos)
            {
                Console.WriteLine($"- {item.Nome} - R${item.Preco}");
            }
            Console.WriteLine("------------");
            Console.WriteLine($"Total a pagar: R${pedido_2.SomaPedido(pedido_2.Produtos):F2}");
            Console.WriteLine("=======================");




        }

    }

}






/*
 Sistema Básico de Pedidos para uma Lanchonete

Contexto

Uma lanchonete deseja informatizar seus pedidos. Atualmente, os atendentes anotam manualmente os pedidos dos clientes, o que pode gerar erros e dificuldades na organização. Seu desafio é criar um sistema simples para gerenciar pedidos, utilizando classes e objetos.

Objetivo

Criar classes que representem os elementos principais da lanchonete e permitir que pedidos sejam registrados e exibidos.

Requisitos do Exercício

1.    Criar as seguintes classes:
      •   Produto: representa um item do cardápio. Deve ter:
            •     Nome do produto
            •     Preço
      •   Pedido: representa um pedido feito por um cliente. Deve ter:
            •     Número do pedido
            •     Lista de produtos (um pedido pode ter vários produtos)
            •     Método para calcular o total do pedido

2.    Criar um programa principal (Main) que:
      •     Cadastre alguns produtos do cardápio (exemplo: Hambúrguer, Refrigerante, Batata Frita).
      •     Crie pelo menos dois pedidos contendo diferentes produtos.
      •     Exiba os detalhes de cada pedido, incluindo os produtos e o total a pagar.

Exemplo de Saída Esperada

Pedido #1
Itens:
- X-Burger - R$ 15,00
- Batata Frita - R$ 8,00
Total: R$ 23,00

Pedido #2
Itens:
- Refrigerante - R$ 5,00
Total: R$ 5,00 
 */