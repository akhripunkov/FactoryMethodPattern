using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2} + Hello Bro";
        }
    }
}

