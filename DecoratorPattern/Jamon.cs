using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Jamon :PizzaDecorator
    {
        public Jamon(Pizza pizza) : base(pizza) { }
        public override string GetDescripcion()
        {
            return this._pizza.GetDescripcion() + ", Jámon" ;
        }

        public override decimal CalcularCosto()
        {
            return  this._pizza.CalcularCosto() + 10.00M;
        }

    }
}
