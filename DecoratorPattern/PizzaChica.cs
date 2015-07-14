using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class PizzaChica:Pizza
    {
        public override string GetDescripcion()
        {
            return "Pizza Chica";
        }

        public override decimal CalcularCosto()
        {
            return 60.00M;
        }

    }
}
