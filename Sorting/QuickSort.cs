using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort : Sort
    {
        public QuickSort(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        //implementing the quick sort algorithm
        public override void implementSort()
        {
            partitionArray(_numberArray, 0, _numberArray.Length - 1);
        }

        //recursive partitioning algorithm for quick sort algorithm
        private void partitionArray(int[] numberArray, int l, int r)
        {
            if(l == r) return;
            int pivot = numberArray[l];
            int i = l + 1;
            for (int j = i; j <= r; j++)
            {
                if (numberArray[j] < pivot)
                {
                    swapArray(ref numberArray, j, i);
                    i = i + 1;
                }
            }
            swapArray(ref numberArray, l, i - 1);
            //partition left array
            partitionArray(numberArray, l, i - 1);
            //partition right array
            partitionArray(numberArray, i, r);
        }

        private void swapArray(ref int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }


    }
}
