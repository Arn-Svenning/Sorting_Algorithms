using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class MergeSortInt : IntSorter
{
    public void Sort(int[] array)
    {
        int arrayLength = array.Length;

        // Divide the arrays until the length of the array is 1
        if (arrayLength == 1)
        {
            return;
        }

        int middle = arrayLength / 2;
        int[] leftArray = new int[middle]; // Create the left array with the size of arrayLength / 2
        int[] rightArray = new int[arrayLength - middle]; // Create the right array with the size of length - middle (you can only include the mid value for 1 array)

        int i = 0; // LeftArray index
        int j = 0; // rightArray index

        for (i = 0; i < arrayLength; i++)
        {
            // Copy all the elements from the regularArray to the divided arrays (left and right)
            if (i < middle)
            {
                leftArray[i] = array[i];
            }
            else
            {
                rightArray[j] = array[i];
                j++;
            }
        }

        Sort(leftArray); // Create new left array until length of the left array is 1
        Sort(rightArray); // Create new right array until length of the right array is 1
        Merge(array, leftArray, rightArray); // Merge all the arrays together
    }
    public void Merge(int[] array, int[] leftArray, int[] rightArray)
    {
        int leftArraySize = array.Length / 2;
        int rightArraySize = array.Length - leftArraySize; // Because the arrays are not always the same size

        int i = 0; // array index
        int leftArrayIndex = 0; // leftArray index;
        int rightArrayIndex = 0; // rightArray index

        while(leftArrayIndex < leftArraySize && rightArrayIndex < rightArraySize)
        {
            // Compare the arrays...
            if (leftArray[leftArrayIndex] < rightArray[rightArrayIndex])
            {
                array[i] = leftArray[leftArrayIndex];
                leftArrayIndex++;
                i++;
            }
            else
            {
                array[i] = rightArray[rightArrayIndex];
                rightArrayIndex++;
                i++;
            }
        }
        
        // Case when there is only 1 element left from either array (no compare is available)
        while(leftArrayIndex < leftArraySize)
        {
            array[i] = leftArray[leftArrayIndex];
            leftArrayIndex++;
            i++;
        }

        while(rightArrayIndex < rightArraySize)
        {
            array[i] = rightArray[rightArrayIndex];
            rightArrayIndex++;
            i++;
        }

        
    }
}

