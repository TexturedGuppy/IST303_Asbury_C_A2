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
        private string iName;
        private int numItems;
        private double price;

        //Default Constructor
        public Item()
        {
            iName = "Nothing Here  ¯\\_(ツ)_/¯ ";
            numItems = 0;
            price = 0;
        }

        //Contructor to populate Item
        public Item(string _iName, int _numItems, double _price)
        {
            iName = _iName;
            numItems = _numItems;
            price = _price;
        }

        /// <summary>
        /// Properties for the Item Class Variables
        /// Doesn't allow negative values, but does allow Zeros
        /// Can have 0 items but not negative items
        /// Can have free items but not negatively priced items
        /// </summary>
        public string IName
        {
            get
            {
                return iName;
            }

            set
            {
                iName = value;
            }
        }

        public int NumItems
        {
            get
            {
                return numItems;
            }
            set
            {
                if (value >= 0)
                {
                numItems = value;
                }
            }
        }


        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                price = value;
                }
            }
        }
    }
}


