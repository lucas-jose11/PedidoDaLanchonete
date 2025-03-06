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
            
            Produto x_Burger = new Produto();
            x_Burger.Nome = "X-Burger";
            x_Burger.Preco = 35.00;
            cardapio.Add(x_Burger);

            Produto x_Calota = new Produto();
            x_Calota.Nome = "X-Calota";
            x_Calota.Preco = 39.99;
            cardapio.Add(x_Calota);

            Produto x_Salada = new Produto();
            x_Salada.Nome = "X-Salada";
            x_Salada.Preco = 14.00;
            cardapio.Add(x_Salada);

            Produto batataFrita = new Produto();
            batataFrita.Nome = "Batata Frita";
            batataFrita.Preco = 35.00;
            cardapio.Add(batataFrita);

            Produto chickenNuggets = new Produto();
            chickenNuggets.Nome = "Pacote de 10 Chicken Nuggets";
            chickenNuggets.Preco = 21.00;
            cardapio.Add(chickenNuggets);

            Produto agua = new Produto();
            agua.Nome = "Água";
            agua.Preco = 4.99;
            cardapio.Add(agua);

            Produto refrigerante = new Produto();
            refrigerante.Nome = "Refrigerante";
            refrigerante.Preco = 8.00;
            cardapio.Add(refrigerante);

           
            foreach (var produto in cardapio)
            {
                produto.PrintCardapio();
            }


















            Console.WriteLine("-------------------");
            Console.WriteLine("Escolha seu pedido, digite 0 para acabar");
            int auxPedido = int.Parse(Console.ReadLine());




            List<Pedido> ordem = new List<Pedido>();

            Pedido pedido = new Pedido();
            pedido.NumeroPedido = 1;
       






            //bota try parse se colcoar negatico ou fora de intervalo

            while (auxPedido !=0)
            {

                switch (auxPedido)
                {
                    case 1:

                        break;


                }

               
            }

            



        }




        static void MostrarCardapio()
        {
           // Produto.PrintCardapio()
        }
    }
}