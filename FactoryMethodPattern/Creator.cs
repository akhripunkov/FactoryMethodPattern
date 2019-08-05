using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Creator:  "
                + product.Operation();

            return result;
        }
    }
}
