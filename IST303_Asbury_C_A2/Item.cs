using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A2
{
    class Item
    {
        //Variables
        string iName;
        int numItems;
        double price;

        //Default Constructor
        public Item()
        {
            iName = "Unnamed Item";
            numItems = 0;
            price = 0;
        }

        public Item(string _iName, int _numItems, double _price)
        {
            iName = _iName;
            numItems = _numItems;
            price = _price;
        }
    }
}
