using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
        public class Morron: PizzaDecorator
    {
            public Morron(Pizza pizza) : base(pizza) { }

            public override string GetDescripcion()
            {
                return this._pizza.GetDescripcion() + ", Pimiento morrón";
            }

            public override decimal CalcularCosto()
            {
                return this._pizza.CalcularCosto() + 15.00M;
            }

    }
}
