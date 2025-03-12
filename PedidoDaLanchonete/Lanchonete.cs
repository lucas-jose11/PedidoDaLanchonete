using Microsoft.VisualBasic.FileIO;

namespace PedidoDaLanchonete
{
    public class Lanchonete


    {
        public static List<Produto> cardapio = new List<Produto>
            {
                new Produto(1, "Hambúrguer", 35.00m),
                new Produto(2, "X-Calota", 55.75m),
                new Produto(3, "X-Salada", 14.00m),
                new Produto(4, "X-Salada", 14.00m),
                new Produto(5, "Batata Frita", 16.83m),
                new Produto(6, "Pacote com 12 chicken nuggets", 25.99m),
                new Produto(7, "Água da casa: Álgua", 4.99m),
                new Produto(8, "Refrigerante", 8.00m),
                new Produto(9, "X-Frango", 17.00m)
            };
        //public List<Produto> cardapio = new List<Produto>(); pq é calsse
        public static List<Pedido> listaDePedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a Lanchonete Da Silva!");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Dê uma olhada em nosso cardápio, e por favor peça os quais você deseja!");


            //Produto x_Frango = new Produto(cardapio.Count + 1, "X-Frango", 17.00m); // ou 9,
            //cardapio.Add(x_Frango);

            //Produto x_Burger = new Produto { Nome = "X-Burger", Preco = 35.00}; se n tivesse construtor
            //x_Burger.Nome = "X-Burger"; ou assim
            //x_Burger.Preco = 35.00;

            PrintItensCardapio(cardapio);

            Console.WriteLine("");

            //--------------------------
            //----------------------------

            CriarPedido();

            //Pedido pedido_1 = new Pedido(listaDePedidos.Count + 1); //o 1 pq fiz o metodo que pega esse int e trasnforma no valor do NumeroPedido
            //pedido_1.Produtos.Add(x_Salada);
            //pedido_1.Produtos.Add(batataFrita);
            //pedido_1.Produtos.Add(agua);
            //listaDePedidos.Add(pedido_1);


            //Console.WriteLine("Detalhes do Pedido #1:");
            //Console.WriteLine("=======================");

            //Console.WriteLine($"Pedido #{pedido_1.NumeroPedido}");
            //Console.WriteLine("Itens:");
            //foreach (var item in pedido_1.Produtos)
            //{
            //    Console.WriteLine($"- {item.Nome} - R${item.Preco}");
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine($"Total a pagar: R${pedido_1.SomaPedido(pedido_1.Produtos)}");// poderia colocar no final ali [...].Produtos):F2}"); mas n fez diferença
            //Console.WriteLine("=======================");
            //------------------
            //-------------------

            Console.WriteLine("\n\n");

            //------------------
            //-------------------
            //Pedido pedido_2 = new Pedido((listaDePedidos.Count + 1)); //o 1 pq fiz o metodo que pega esse int e trasnforma no valor do NumeroPedido
            //pedido_2.Produtos.Add(x_Calota);
            //pedido_2.Produtos.Add(chickenNuggets);
            //pedido_2.Produtos.Add(refrigerante);
            //listaDePedidos.Add(pedido_2);


            //Console.WriteLine("Detalhes do Pedido #2:");
            //Console.WriteLine("=======================");

            //Console.WriteLine($"Pedido #{pedido_2.NumeroPedido}");
            //Console.WriteLine("Itens:");
            //foreach (var item in pedido_2.Produtos)
            //{
            //    Console.WriteLine($"- {item.Nome} - R${item.Preco}");
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine($"Total a pagar: R${pedido_2.SomaPedido(pedido_2.Produtos)}"); 
            //Console.WriteLine("=======================");
            //------------------
            //-------------------

            Console.WriteLine("\nObrigado por vir em nossa lanchoente, volte sempre!");

            //COMO DEIXAR ISSO AUTOMATICO, COMO DEIXAR O CLIENTE ESCOLHER OS PRODUTOS E O NUMEROPEDIDO AUMENTAR PRO PROXIMO PEDDIDO, SEM UM LIMITE 
        }

        public static void PrintItensCardapio(List<Produto> cardapio)
        {
            foreach (var p in cardapio)
            {
                Console.WriteLine($"{p.Nome} || R${p.Preco} || ID:{p.Id}"); //mascarar dados "mascara"? o :0.00, tbm da certo Preco:C2, DECIMAL N PRECISA DISSO
            }
        }

        public void CriarPedido()
        {
            List<Produto> carrinhoCompras = new List<Produto>();

            int opcao = -1;
            while (opcao != 0)
            {
                Console.WriteLine("Escreva o número correspndete ao item que você deseja em seu pedido.");
                opcao = int.Parse(Console.ReadLine());

                //var variavel = cardapio.Select(p => p.Id == opcao);
                //if (variavel != null) //link expressions OU FAZ COM SWITCH CASE
                //   carrinhoCompras.Add(cardapio[opcao + 1]);

                var produtoCardapio = cardapio.Where(x => x.Id == opcao).FirstOrDefault(); // era antes Produto adicionandoAoCarrinho
                if (produtoCardapio == null)
                {
                    Console.WriteLine("Digite uma opção válida.");
                    continue; //pra continuar pro proximo laço de repetição
                }
                carrinhoCompras.Add(produtoCardapio); //else

            }

            Pedido comandaPedido = new Pedido();

            //CRIAR O PEDIDO, NUMEROPEDIDO
            //rainbow braces - extensao boa
            //uma classe é um, singular, lista de produtos n vai estar na classe produto
        } 

    }

}

/*
 Sistema Básico de Pedidos para uma Lanchonete

-Contexto

Uma lanchonete deseja informatizar seus pedidos. 
Atualmente, os atendentes anotam manualmente os pedidos dos clientes, o que pode gerar erros e dificuldades na organização. 
Seu desafio é criar um sistema simples para gerenciar pedidos, utilizando classes e objetos.

-Objetivo

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


-Exemplo de Saída Esperada:

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