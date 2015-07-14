using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Refresco : PizzaDecorator
    {
        public Refresco(Pizza pizza) : base(pizza) { }

        public override string GetDescripcion()
        {
            return this._pizza.GetDescripcion() + ", Refresco";
        }

        public override decimal CalcularCosto()
        {
            return base.CalcularCosto() + 20.00M ;
        }


    }
}
