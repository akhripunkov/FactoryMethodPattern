using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "Product 1 result of operation";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "Product 2 result of operation";
        }
    }
}

