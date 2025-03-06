using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDaLanchonete
{
    internal class Produto
    {
        public void PrintCardapio()
        {
            Console.WriteLine($"{Nome} || R${Preco:0.00}."); //mascarar dados "mascara"? o :0.00
        }

        public string Nome;
        public double Preco;





        //Produto: representa um item do cardápio.Deve ter:
        //  Nome do produto
        //  Preço
    }
}
