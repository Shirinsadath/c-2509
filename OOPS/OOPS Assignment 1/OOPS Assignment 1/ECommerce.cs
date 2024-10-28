using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    //public class ECommerce
    //{
    //    // Inner class to represent a Product
    //    private class Product
    //    {
    //        private string name;
    //        private decimal price;
    //        private int stock;

    //        public string Name
    //        {
    //            get { return name; }
    //            set { name = value; }
    //        }

    //        public decimal Price
    //        {
    //            get { return price; }
    //            set
    //            {
    //                if (value < 0)
    //                {
    //                    throw new ArgumentException("Price cannot be negative.");
    //                }
    //                price = value;
    //            }
    //        }

    //        public int Stock
    //        {
    //            get { return stock; }
    //            set
    //            {
    //                if (value < 0)
    //                {
    //                    throw new ArgumentException("Stock cannot be less than zero.");
    //                }
    //                stock = value;
    //            }
    //        }

    //        public Product(string name, decimal price, int stock)
    //        {
    //            Name = name;
    //            Price = price;
    //            Stock = stock;
    //        }

    //        public void Display()
    //        {
    //            Console.WriteLine($"Product: {Name}, Price: {Price:C}, Stock: {Stock}");
    //        }
    //    }

    //    // Inner class to represent an Order
    //    private class Order
    //    {
    //        public void CreateOrder(Product product, int quantity)
    //        {
    //            if (quantity <= 0)
    //            {
    //                Console.WriteLine("Quantity must be greater than zero.");
    //                return;
    //            }

    //            if (product.Stock >= quantity)
    //            {
    //                product.Stock -= quantity;
    //                Console.WriteLine($"Order created for {quantity} of {product.Name}. Remaining stock: {product.Stock}");
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Not enough stock for {product.Name}. Available: {product.Stock}, Requested: {quantity}");
    //            }
    //        }
    //    }
    //}
}
