//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace OOPS_Assignment_1
//{
//    public class Item
//    {
//        public string Name { get; set; }
//        private int stock;
//        private double price;

//        public int Stock
//        {
//            get { return stock; }
//            set
//            {
//                if (value >= 0)
//                {
//                    stock = value;
//                }
//                else
//                {
//                    Console.WriteLine("Stock cannot be negative.");
//                }
//            }
//        }

//        public double Price
//        {
//            get { return price; }
//            set
//            {
//                if (value >= 0)
//                {
//                    price = value;
//                }
//                else
//                {
//                    Console.WriteLine("Price cannot be negative.");
//                }
//            }
//        }

//        public Item(string name, int stock, double price)
//        {
//            Name = name;
//            Stock = stock;
//            Price = price;
//        }

//        public override string ToString()
//        {
//            return $"Name: {Name}, Stock: {Stock}, Price: ${Price:F2}";
//        }
//    }

//    class Inventory
//    {
//        private List<Item> items = new List<Item>();

//        public void AddItem(Item item)
//        {
//            items.Add(item);
//            Console.WriteLine($"Item '{item.Name}' added to inventory.");
//        }

//        public void RemoveItem(string name)
//        {
//            Item itemToRemove = items.Find(item => item.Name == name);
//            if (itemToRemove != null)
//            {
//                items.Remove(itemToRemove);
//                Console.WriteLine($"Item '{itemToRemove.Name}' removed from inventory.");
//            }
//            else
//            {
//                Console.WriteLine("Item not found.");
//            }
//        }

//        public void UpdateItem(string name, int newStock, double newPrice)
//        {
//            Item itemToUpdate = items.Find(item => item.Name == name);
//            if (itemToUpdate != null)
//            {
//                itemToUpdate.Stock = newStock;
//                itemToUpdate.Price = newPrice;
//                Console.WriteLine($"Item '{itemToUpdate.Name}' updated.");
//            }
//            else
//            {
//                Console.WriteLine("Item not found.");
//            }
//        }

//        public void DisplayItems()
//        {
//            if (items.Count > 0)
//            {
//                Console.WriteLine("Items in inventory:");
//                foreach (var item in items)
//                {
//                    Console.WriteLine(item);
//                }
//            }
//            else
//            {
//                Console.WriteLine("No items in inventory.");
//            }
//        }
//    }




//================================================================================================================
public class Inventory
{
    private class Item
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public Item(string name, int stock, decimal price)
        {
            Name = name;
            Stock = stock >= 0 ? stock : 0;
            Price = price >= 0 ? price : 0;
        }

        public void Display()
        {
            Console.WriteLine($"Item: {Name}, Stock: {Stock}, Price: {Price}");
        }
    }

    private List<Item> items;

    public Inventory()
    {
        items = new List<Item>();
    }

    public void AddItem(string name, int stock, decimal price)
    {
        Item newItem = new Item(name, stock, price);
        items.Add(newItem);
        Console.WriteLine($"{name} is Added");
    }

    public void RemoveItem(string name)
    {
        Item itemToRemove = null;
        foreach (var item in items)
        {
            if (item.Name == name)
            {
                itemToRemove = item;
                break;
            }
        }
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            Console.WriteLine($"Removed : {name}");
        }
        else
        {
            Console.WriteLine($"Item not found : {name}");
        }
    }

    public void UpdateStock(string name, int newStock)
    {
        Item itemToUpdate = null;
        foreach (var item in items)
        {
            if (item.Name == name)
            {
                itemToUpdate = item;
                break;
            }
        }
        if (itemToUpdate != null)
        {
            itemToUpdate.Stock = newStock;
            Console.WriteLine($"Updated stock : {name}");
        }
        else
        {
            Console.WriteLine($"Item not found : {name}");
        }
    }

    public void UpdatePrice(string name, decimal newPrice)
    {
        Item itemToUpdatePrice = null;
        foreach (var item in items)
        {
            if (item.Name == name)
            {
                itemToUpdatePrice = item;
                break;
            }
        }
        if (itemToUpdatePrice != null)
        {
            itemToUpdatePrice.Price = newPrice;
            Console.WriteLine($"Updated price for: {name}");
        }
        else
        {
            Console.WriteLine($"Item not found: {name}");
        }

    }

    public void DisplayAllItems()
    {
        Console.WriteLine("Inventory Items:");
        foreach (var item in items)
        {
            item.Display();
        }
    }
}

