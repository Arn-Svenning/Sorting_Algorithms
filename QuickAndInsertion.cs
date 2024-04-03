using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QuickAndInsertion : IntSorter
{
    private Random random = new Random(); // Add a random number generator

    private int M = 60;

    //private InsertionSort insertionSort = new InsertionSort();

    public void Sort(int[] array)
    {
        QuickSort(array, 0, array.Length - 1);
    }

    public void QuickSort(int[] array, int start, int end)
    {       
        while(end > start) 
        {
            if (end - start + 1 < M) // If the size of the array is less than M
            {
                InsertionSortForQuick(array, start, end);
                return;
            }
            else
            {               
                // Generate a random index within the range [start, end]
                int randomIndex = random.Next(start, end);

                // Swap the element at the random index with the last element
                int temp = array[randomIndex];
                array[randomIndex] = array[end];
                array[end] = temp;

                // Choose a random pivot element in order to prevent running time of O(N^2) which happens if the array is already sorted
                int pivot = Partition(array, start, end);

                if (pivot - start < end - pivot)
                {
                    QuickSort(array, start, pivot - 1);
                    start = pivot + 1;
                }
                else
                {
                    QuickSort(array, pivot + 1, end);
                    end = pivot - 1;
                }

                
            }
        }
        
        
    }
    public int Partition(int[] array, int start, int end)
    {
        int pivot = array[end]; // Pivot is always at the end of the array

        int i = start - 1;

        for (int j = start; j <= end - 1; j++)
        {
            // If j is smaller than the pivot... Switch the values of incremented i and current position of j
            if (array[j] < pivot)
            {
                i++;
                int temporary = array[i];
                array[i] = array[j];
                array[j] = temporary;
            }
        }
        i++; // Increment i again to divide the array based on elements smaller than the pivot and larger than the pivot
        int temp = array[i];
        array[i] = array[end];
        array[end] = temp; // Replace the pivot value with i so that it's organized with smaller - pivot - larger

        return i; // Return i to show index of pivot
    }
    public void InsertionSortForQuick(int[] arr, int low, int n)
    {

        for (int i = low + 1; i <= n; i++)
        {
            int val = arr[i];
            int j = i;
            while (j > low && arr[j - 1] > val)
            {
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = val;
        }

    }
}



