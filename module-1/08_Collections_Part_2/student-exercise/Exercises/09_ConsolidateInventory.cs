using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
            Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> combinedValues = new Dictionary<string, int>();

            //iterate through 1st main dictionary and add to new dictionary.
            foreach (KeyValuePair<string, int> item in mainWarehouse)
            {
                combinedValues.Add(item.Key, item.Value);
            }
            //iterate through second dictionary and add the values to the first int the new dictionary.
            foreach (KeyValuePair<string, int> item in remoteWarehouse)
            {
               if (combinedValues.ContainsKey(item.Key))
                {
                    combinedValues[item.Key] = remoteWarehouse[item.Key] + combinedValues[item.Key];
                }
               else
                {
                    combinedValues.Add(item.Key, item.Value);
                }
            }
            return combinedValues;
        } //what I have so far, talk to John.
    }
}
