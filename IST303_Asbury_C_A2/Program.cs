using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendor v = new Vendor();
            int choice = 0;
            string selection;
            bool bResult;

            //Looping Menu
            while (choice != -1)
            {
                v.print();
                selection = Console.ReadLine();
                bResult = Int32.TryParse(selection, out choice);

                if (!bResult)
                {
                    Console.WriteLine("Invalid Input, Not Recognized Try Again");
                    continue;
                }
                switch (choice)
                {
                    case 0:
                        v.itemSelection(choice);
                        break;
                    case 1:
                        v.itemSelection(choice);
                        break;
                    case 2:
                        v.itemSelection(choice);
                        break;
                    case 3:
                        v.itemSelection(choice);
                        break;
                    case 4:
                        v.itemSelection(choice);
                        break;
                    case -1:
                        Console.WriteLine("Your final total is {0,0:C}",v.Total);
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                    
                }
            }
        }
        
        
    }
    
    
}


        
    

