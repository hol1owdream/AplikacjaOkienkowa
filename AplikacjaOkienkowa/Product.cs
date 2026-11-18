using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

//zakres nazw w którym pracujemy, w którym nazwy są nie powtarzalne
namespace AplikacjaOkienkowa
{
    internal class Product
    {
        // nazwa produktu
        public string Name { get; set; }

        // cena produktu
        public double Price { get; set; }

        // kategoria, do której należy produkt
        public string Category { get; set; }

        // konstruktor przypisujący wartości na start
        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}