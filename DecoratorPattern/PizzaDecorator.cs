using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
   public class PizzaDecorator :Pizza
    {
       protected Pizza _pizza;

       public PizzaDecorator(Pizza pizza)
       {
           this._pizza = pizza;
       }

       public override string GetDescripcion()
       {
           return this._pizza.GetDescripcion();
       }

       public override decimal CalcularCosto()
       {
           return this._pizza.CalcularCosto();
       }


    }
}
