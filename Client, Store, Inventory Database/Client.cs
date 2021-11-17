using System;

namespace midtermProject
{
    class Client
    {
        static void Main()
        {
            //variable declarations
            int userResponse;
            int itemID;
            int quantityOrdered;
            //create instantiation of the inventory
            Inventory inventory = new Inventory();


            //welcome message
            Console.WriteLine("Welcome to the Peter's store for his Midterm!!\nEnter a number below for the menu.");

            //main loop
            do
            {
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Check whether an Item is in the store");
                Console.WriteLine("3. Update Amount (Item has been sold)");
                Console.WriteLine("4. Print the report");
                Console.WriteLine("Type any other numnber to exit.");

                userResponse = Convert.ToInt32(Console.ReadLine());
                //switch case
                switch (userResponse)
                {
                    case 1:       
                        string[] input = new string[4];
                        int i = 0;
                        Console.WriteLine("Please Enter New Item Name, ID, Amount in Stock, Manuf. Price, and Selling Price (Press Enter Inbetween)) \n");
                        while(i <= 4)
                        {
                            input[i] = Console.ReadLine();
                            i++;
                        }
                        
                        new Item(int.Parse(input[1]), input[0], int.Parse(input[2]), Convert.ToDouble(input[3]), Convert.ToDouble(input[4]));
                        inventory.print();
                        Console.Write("\n Thank You! ");
                        break;
                    case 2:
                        Console.Write("Please enter the item ID: ");
                        itemID = Convert.ToInt32(Console.ReadLine());
                        if (inventory.checkInStore(itemID))
                            Console.WriteLine("The item is in the store.\n");
                        else
                            Console.WriteLine("The item is not in the store.\n");
                        break;
                    case 3:
                        Console.Write("Please enter the item ID: ");
                        itemID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please enter the quantity ordered: ");
                        quantityOrdered = Convert.ToInt32(Console.ReadLine());
                        inventory.updateQuantity(quantityOrdered, itemID);
                        break;
                    case 4:
                        inventory.print();
                        break;
                    default:
                        Console.WriteLine("Thank You!");
                        break;
                }
            } while (userResponse < 4 && userResponse > 0);

        }
    }
}
