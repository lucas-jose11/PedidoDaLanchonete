using Microsoft.VisualBasic.FileIO;
using static PedidoDaLanchonete.Organizacao;

namespace PedidoDaLanchonete
{
    public class Lanchonete
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo a Lanchonete Da Silva!");
            Console.WriteLine("Escolha uma opção");

            int op = -1;
            while (op != 0) 
            {
                op = Organizacao.MostrarMenu(); // só precisa disso se n tiver a linha 2 ali, com ela, pode só o Mostrarmenu();
            } 
            
            Console.WriteLine("\nObrigado por vir em nossa lanchonete, volte sempre!");
       
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