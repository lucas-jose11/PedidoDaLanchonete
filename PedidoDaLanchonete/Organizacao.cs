
namespace PedidoDaLanchonete
{
    public class Organizacao
    {
        public static List<Produto> cardapio = new List<Produto>
        {
            new Produto("Hambúrguer", "19,50"),
            new Produto("Batatas Fritas", "9,50"),
            new Produto("Refigerante Guaraná 600ml", "8,45"),
        };

        public static List<Pedido> listaDePedidos = new List<Pedido>();

        public static int MostrarMenu()
        {
            Console.WriteLine("[1] - Cadastrar produto no cardápio.");
            Console.WriteLine("[2] - Mostrar cardápio atual.");
            Console.WriteLine("[3] - Fazer o pedido.");
            Console.WriteLine("[4] - Visualizar pedido.");
            Console.WriteLine("[0] - PARA SAIR.");
            int op = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (op)
            {

                case 1:
                    CadastrarItemCardapio();
                    break;

                case 2:
                    MostrarCardapio();
                    Console.ReadLine();
                    break;

                case 3:
                    CadastrarPedido();
                    break;

                case 4:
                    MostrarPedidos();
                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Digite uma opção válida.");
                    Console.WriteLine("Para voltar ao menu, digite qualquer tecla...");
                    Console.ReadLine();
                    break;
            }
            Console.Clear();

            return op;
        }

        public static void CadastrarItemCardapio()
        {

            Console.WriteLine("Escreva o nome do item que deseja adicionar ao nosso cardápio.");
            string nomeItem = Console.ReadLine();
            Console.WriteLine("Escreva o preço dele, usando o padrão \"00,00\"");
            decimal preçoItem = decimal.Parse(Console.ReadLine());
            string preçoItemFormatado = preçoItem.ToString("F2");

            Produto itemNoCardapio = new Produto(nomeItem, preçoItemFormatado);
            cardapio.Add(itemNoCardapio);

            Console.WriteLine("Item cadastrado!");
        }

        public static void MostrarCardapio()
        {
            Console.WriteLine("Nosso cardápio:");
            for (int i = 0; i < cardapio.Count; i++)
            {
                Produto produto = cardapio[i];
                Console.WriteLine($"[{i + 1}] - {produto.Nome} || R${produto.Preco}");
            }
        }

        public static void CadastrarPedido()
        {
            List<Produto> carrinhoCompras = new List<Produto>();

            int opcaoEscolhida = -1;
            while (opcaoEscolhida != 0)
            {
                if (carrinhoCompras.Count > 0)
                {
                    Console.WriteLine("Item adicionado ao pedido com sucesso!");
                }
                Console.WriteLine("============================================");
                MostrarCardapio();
                Console.WriteLine("============================================");

                Console.WriteLine("Escreva o número correspndete ao item que você deseja em seu pedido.");
                Console.WriteLine("[0] - TERMINAR PEDIDO");

                opcaoEscolhida = int.Parse(Console.ReadLine());

                if (opcaoEscolhida >= 1 && opcaoEscolhida <= cardapio.Count)
                {
                    int indice = opcaoEscolhida - 1;
                    carrinhoCompras.Add(cardapio[indice]);
                }

                if (opcaoEscolhida == 0)
                {
                    break;
                }
                
                Console.WriteLine("Adicionando ao carrinho...");
                Thread.Sleep(1000);
                Console.Clear();
            }

            if (carrinhoCompras.Count > 0)
            {
                int numeroPedido = listaDePedidos.Count + 1;

                Pedido novoPedido = new Pedido(numeroPedido, carrinhoCompras);
                listaDePedidos.Add(novoPedido);
            }
            else if (carrinhoCompras.Count == 0)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("Nenhum pedido foi feito. Voltando ao menu...");
                Console.WriteLine("===========================================");
                Thread.Sleep(1800);
            }
        }

        public static void MostrarPedidos()
        {
            for (int i = 0; i < listaDePedidos.Count; i++)
            {
                Pedido pedidoAtual = listaDePedidos[i];
                Console.WriteLine("==================================");
                Console.WriteLine($"Detalhes do pedido #{pedidoAtual.NumeroPedido}");

                foreach (Produto j in pedidoAtual.Produtos)
                {
                    Console.WriteLine($"Item: {j.Nome} || Preço: R${j.Preco}");
                }

                Console.WriteLine($"Total do pedido: R${SomaTotal(pedidoAtual.Produtos)}.");
                Console.WriteLine("==================================");
                Console.WriteLine("");
            }
                Console.WriteLine("\nClique em qualquer para voltar ao menu.");
                Console.ReadLine();
        }

        public static decimal SomaTotal(List<Produto> produtos)
        {
            decimal totalPedido = 0;
            foreach (Produto item in produtos)
            {
                decimal precoFormatado = decimal.Parse(item.Preco);
                totalPedido += precoFormatado; 
            }
            return totalPedido;
        }
    }

}