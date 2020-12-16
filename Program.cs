using System;
using MetodosConstrutores.Classes;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
                Console.WriteLine($"codigo - {produto1.Codigo}, nome - {produto1.Nome ?? "sem nome"}, " +$"descricao - {produto1.Descricao}, estoque - {produto1.Estoque}");

            Produto produto2 = new Produto(15858);
                Console.WriteLine($"codigo - {produto2.Codigo}, nome - {produto2.Nome ?? "sem nome"}, " +$"descricao - {produto2.Descricao}, estoque - {produto2.Estoque}");
 
            Produto produto3 = new Produto(158696,"produto Arroz","este é o produto Arroz",20);
                Console.WriteLine($"codigo - {produto3.Codigo}, nome - {produto3.Nome ?? "sem nome"}, " +$"descricao - {produto3.Descricao}, estoque - {produto3.Estoque}");
                
            Console.ReadLine();

        }
    }
}
