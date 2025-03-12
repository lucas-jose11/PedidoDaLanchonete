using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDaLanchonete
{
    public class Organizacao
    {
        public static List<Produto> cardapio = new List<Produto>();

        public static List<Pedido> listaDePedidos = new List<Pedido>();


        public static int MostrarMenu()
        {
            Console.WriteLine("1- Cadastrar produto no cardápio.");
            Console.WriteLine("2- Mostrar cardápio atual.");
            Console.WriteLine("3- Fazer o pedido.");
            Console.WriteLine("4- Visualizar pedido.");
            Console.WriteLine("0- PARA SAIR.");
            int op = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (op)
            {

                case 1:
                    CadastrarNoCardapio();
                    break;

                case 2:
                    PrintItensCardapio(cardapio);
                    Console.ReadLine();
                    break;

                case 3:
                    CriarPedido();
                    break;

                case 4:
                    MostrarPedidos();
                    break;

                case 0:
                    Console.WriteLine("Falou");
                    break;

                default:
                    Console.WriteLine("Digite uma opção válida.");
                    break;
            }
            Console.Clear();

            return op;
        }

        public static void CadastrarNoCardapio()
        {
            Console.WriteLine("Escreva o nome do item.");
            string nomeItem = Console.ReadLine();
            Console.WriteLine("Escreva o preço dele, usando o padrão \"00,00\"");
            decimal preçoItem = decimal.Parse(Console.ReadLine());

            Produto itemNoCardapio = new Produto { Nome = nomeItem, Preco = preçoItem };
            cardapio.Add(itemNoCardapio);
        }

        public static void PrintItensCardapio(List<Produto> cardapio)
        {
            for (int i = 0; i < cardapio.Count; i++)
            {
                Produto produto = cardapio[i]; // puxa o produto do cardapio com o i como index
                Console.WriteLine($"[{i + 1}] - {produto.Nome} || R${produto.Preco}"); //mascarar dados "mascara"? o :0.00, tbm da certo Preco:C2, DECIMAL N PRECISA DISSO
            }
        }

        public static void CriarPedido()
        {
            List<Produto> carrinhoCompras = new List<Produto>();

            int opcaoEscolhida = -1;
            while (opcaoEscolhida != 0)
            {
                PrintItensCardapio(cardapio);
                Console.WriteLine("0- PARA TERMINAR PEDIDO");
                Console.WriteLine("Escreva o número correspndete ao item que você deseja em seu pedido.");

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
            }

            if (carrinhoCompras.Count > 0)
            { 
                int numeroPedido = listaDePedidos.Count + 1;

                Pedido novoPedido = new Pedido(numeroPedido, carrinhoCompras);
                listaDePedidos.Add(novoPedido);
            }

            //ISSO FUNCIONARIA SE A CLASSE PEDIDO TIVESSE UM CONSTRUTOR SEM PARAMETROS(PADRAO), MAS EU DEFINE UM COM, ENT O CONSTRUTOR PADRAO N EXISTE MAIS
            //Pedido novoPedido = new Pedido
            //{
            //    NumeroPedido = numeroPedido,
            //    Produtos = carrinhoCompras
            //};
            //listaDePedidos.Add(novoPedido);
            
            
            //Console.WriteLine("Pedido feito com sucesso!");
            //var variavel = cardapio.Select(p => p.Id == opcaoEscolhida);
            //if (variavel != null) //link expressions OU FAZ COM SWITCH CASE
            //    carrinhoCompras.Add(cardapio[opcaoEscolhida + 1]);

            //var produtoCardapio = cardapio.Where(x => x.Id == opcaoEscolhida).FirstOrDefault(); // era antes Produto adicionandoAoCarrinho, e tbm, usava isso qnd tinha Id no Produto
            //if (produtoCardapio == null)
            //{
            //    Console.WriteLine("Digite uma opção válida.");
            //    continue; //pra continuar pro proximo laço de repetição
            //}
            //carrinhoCompras.Add(produtoCardapio); //else



            //Pedido comandaPedido = new Pedido();

            //CRIAR O PEDIDO, NUMEROPEDIDO
            //rainbow braces - extensao boa
            //uma classe é um, singular, lista de produtos n vai estar na classe produto
        } //ENTENDER A PIRA QUE EU FIZ E DEU CERTO, PEDIR AJUDA PARA VER SE MELHORA/DEIXA IGUAL

        public static void MostrarPedidos(List<Pedido> listaDePedidos)
        {
            Console.WriteLine($"Detalhes do pedido #{listaDePedidos.NumeroPedido}"); //ARRUMAR AQUI
            foreach (var p in listaDePedidos)
            {
                Produto produto = listaDePedidos[p];
                Console.WriteLine($"{produto.Nome} || {produto.Preco}");
            }
            Console.WriteLine($"Total a pagar: {SomaTotal(listaDePedidos)}");
        }

        public static decimal SomaTotal(List<Produto> produtos)
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