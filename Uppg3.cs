using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Uppg3 : IntSorter
{
    public void Sort(int[] array)
    {
        SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();
                
        // Copy the elements from the array
        foreach (int num in array)
        {
            if (sortedDict.ContainsKey(num)) // If the sortedDictionary already contains this "number" / key then increment the value of that key
            {
                sortedDict[num]++;
            }
            else // If that number / key doesn't exist then add the key and increment the value to 1
            {
                sortedDict[num] = 1;
            }
        }        

        int index = 0;

        
        foreach (var kvp in sortedDict) // Loop through all the keys
        {
            for (int i = 0; i < kvp.Value; i++) // Loop through the values of the keys, if i < 3, then add 3 of that key to the array
            {
                array[index] = kvp.Key;
                index++;
            }
        }

    }
}


