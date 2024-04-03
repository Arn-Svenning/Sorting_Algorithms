using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InsertionSort : IntSorter
{
    public void Sort(int[] a)
    {
        int N = a.Length;
        for (int i = 0; i < N; i++)
        {
            for (int j = i; j > 0 && a[j] < a[j - 1]; j--)
            {
                int x = a[j]; a[j] = a[j - 1]; a[j - 1] = x;
            }
        }
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
