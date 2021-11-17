using System;
using System.Collections;

namespace midtermProject
{
    
    public class Inventory
    {
        //declare ArrayList
        ArrayList items = new ArrayList();

        //declare total count
        double totalPrice;
        int totalItems;

        //constructor, takes no values, calls the below method to construct the inventory ArrayList
        public Inventory()
        {
            createInventory();
        }

        //method to create 5 items
        public void createInventory()
        {
            items.Add(new Item(72, "Xbox", 15, 59.99, 499.99));
            items.Add(new Item(92, "Playstation", 5, 349.99, 499.99));
            items.Add(new Item(245, "Switch", 20, 249.99, 299.99));
            items.Add(new Item(783, "Pineapple", 35, 36.99, 9.99));
            items.Add(new Item(64, "Tuna", 65, 39.99, 2.99));
        }

        //check if item in list
        public Boolean checkInStore(int ID)
        {
            foreach(Item x in items)
            {
                if (x.itemID == ID && x.StockHolder > 0)
                    return true;
            }
            return false;
        }

        //update quantity
        public void updateQuantity(int selling, int ID)
        {
            int quant = quantity(ID);
            if(quant - selling > -1)
            {
                foreach(Item x in items)
                {
                    if (x.itemID == ID)
                    {
                        x.StockHolder -= selling;
                        Console.WriteLine(selling + " items with ID " + ID + " have been sold out.\n");
                    }
                }
            }
            else
                Console.WriteLine("The store does not contain that many of the requested item, however there are " + quantity(ID) + " of those items left!\n");
        }

        //method to return the quantity of item
        public int quantity(int ID)
        {
            foreach(Item x in items)
            {
                if (x.itemID == ID)
                    return x.StockHolder;
            }
            return 0; //case where the requested item is not in the store
        }

        //method to calculate total price
        public double calcTotalPrice()
        {
            foreach(Item x in items)
            {
                totalPrice += (x.StockHolder * x.sellingPrice);
            }
            return totalPrice;
        }

        //method to calculate total number of items
        public int calcTotalItems()
        {
            foreach(Item x in items)
            {
                totalItems += x.StockHolder;
            }
            return totalItems;
        }
                     
        //output string 
        public void print()
        {
            Console.WriteLine("ItemID\tItemName\tInStock\tmanufPrice\tsellingPrice");
            foreach(Item x in items)
            {
                Console.WriteLine(x.print());
            }
            Console.WriteLine("\nTotal Inventory: " + calcTotalPrice().ToString("C2"));
            Console.WriteLine("Total Number of items in the store: " + calcTotalItems() + "\n");
        }
    }
}
