using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A2
{
    //Vendor Class
    //Populates the Vending Machine
    class Vendor
    {
        //Item Array
        private Item[] inv = new Item[5];
        double total = 0;

        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        //Vendor Constructor, populates an array of items
        public Vendor()
        {
            inv[0] = new Item("Gumbo", 3, 5.50);
            inv[1] = new Item("Steak Dinner", 13, 14.99);
            inv[2] = new Item("Miracle Whip Sandwich", 2, 2.99);
            inv[3] = new Item("Canned Water", 4, .50);
            inv[4] = new Item("Gummy Worms", 1, 1.30);
        }

        //Prints out Inventory to the screen
        public void print()
        {
            int itemN = 0;
            //Formats everything to look nice on the screen
            Console.WriteLine("{0, 0} {1, -30} {2,10} {3, -30}", "Selection", "Product", "Price", "Stock");
            //Prints all the items in the inventory
            foreach (Item item in inv)    
            {
                Console.WriteLine("{0, 9} {1, -30} {2, 10:C} {3, -30}", itemN, item.IName, item.Price, item.NumItems);
                itemN++;
            }
                
            Console.WriteLine("-1 to Exit");	
        }

        //Selects an item, if the item is out of stock tells user to select another
        public void itemSelection(int sel)
        {
            //local variables
            string totalBought;
            bool bResult = false;
            int amount = 0;

            Console.WriteLine("You have selected {0}.", inv[sel].IName);

            //Out of Stock checker
            if (inv[sel].NumItems <= 0)
            {
                Console.WriteLine("{0} is out of stock, please make another selection.", inv[sel].IName);
                return;
            }

            //Checks to see if user actually inputs a number of items
            Console.WriteLine("How many would you like to buy?");
            totalBought = Console.ReadLine();
            bResult = Int32.TryParse(totalBought, out amount);
            if (!bResult)
            {
                Console.WriteLine("Invalid Input, Not Recognized Try Again");
                itemSelection(sel);
            }
            else
            {
                calculateTotal(amount,sel);
            }
                
        }

        //Function for calculating a running total
        void calculateTotal(int amount, int indexOfItem)
        {
            if (inv[indexOfItem].NumItems > 0)
                inv[indexOfItem].NumItems -= amount;
            

            else
                itemSelection(indexOfItem);
            Total += amount * inv[indexOfItem].Price;
            Console.WriteLine("Your current total for this purchase {0, 0:C}", Total);
           // return total;

        }
            


    }
}



                





