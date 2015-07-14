using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Pizza
    {
        public abstract string GetDescripcion();
        public abstract decimal CalcularCosto();
    }
}
