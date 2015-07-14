using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class PizzaMediana : Pizza
    {
        public override string GetDescripcion()
        {
            return "Pizza Mediana";
        }

        public override decimal CalcularCosto()
        {
            return 70.00M;
        }

    }
}
