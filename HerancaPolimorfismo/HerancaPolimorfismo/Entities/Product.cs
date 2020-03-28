﻿using System.Globalization;

namespace HerancaPolimorfismo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return string.Concat(Name, " $ ", Price.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
