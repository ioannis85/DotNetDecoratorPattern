using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizzaGrande = new PizzaGrande();
            pizzaGrande = new Jamon(pizzaGrande);
            pizzaGrande = new Tocino(pizzaGrande);
            pizzaGrande = new Morron(pizzaGrande);
            pizzaGrande = new Refresco(pizzaGrande);

            Console.WriteLine("{0}", pizzaGrande.GetDescripcion());
            Console.WriteLine("{0 :C2}", pizzaGrande.CalcularCosto());
            Console.ReadLine();


        }
    }
}
