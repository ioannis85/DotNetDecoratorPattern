using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Tocino : PizzaDecorator
    {
        public Tocino(Pizza pizza) : base(pizza) { }

        public override string GetDescripcion()
        {
            return this._pizza.GetDescripcion() + ", Tocino";
        }

        public override decimal CalcularCosto()
        {
            return this._pizza.CalcularCosto() + 20.00M;
        }

    }
}
