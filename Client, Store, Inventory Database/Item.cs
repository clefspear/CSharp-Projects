using System;
namespace midtermProject
{
    public class Item
    {
        
        public int itemID;
        public string name;
        public int StockHolder;
        public double manufPrice;
        public double sellingPrice;

        //accessors
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int PInStore { get; set; }
        public double ManufPrice { get; set; }
        public double SellingPrice { get; set; }

        //constructor
        public Item(int itemID, string name, int InStock, double manufPrice, double sellingPrice)
        {
            this.itemID = itemID;
            this.name = name;
            this.StockHolder = InStock;
            this.manufPrice = manufPrice;
            this.sellingPrice = sellingPrice;
        }

        //printing string
        public string print()
        {
            return " " + itemID + "\t" + name + "\t" + StockHolder + "\t\t" + manufPrice + "\t\t" + sellingPrice;
        }
    }
}
