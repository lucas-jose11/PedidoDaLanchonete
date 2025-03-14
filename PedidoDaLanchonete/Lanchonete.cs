﻿
namespace PedidoDaLanchonete
{
    public class Lanchonete
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bem-vindo a Lanchonete Da Silva!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Escolha uma opção e digite ela abaixo:");

                int op = -1;
                while (op != 0)
                {
                    op = Organizacao.MostrarMenu();
                }

                Console.WriteLine("Obrigado por vir em nossa lanchonete, volte sempre!");

            } catch (Exception e)
            {
                Console.WriteLine($"OCORREU UM ERRO INESPERADO: {e.Message}");
            }
        }
    }
}