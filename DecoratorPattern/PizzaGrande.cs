using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
   public class PizzaGrande : Pizza
    {
       public override string GetDescripcion()
       {
           return "Pizza Grande";
       }

       public override decimal CalcularCosto()
       {
           return  80.00M ;
       }


    }
}
