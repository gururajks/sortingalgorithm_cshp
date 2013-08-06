using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort : Sort
    {
        int _numberOfComparisons = 0;
        public QuickSort(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        //implementing the quick sort algorithm
        public override void implementSort()
        {
            partitionArray(_numberArray, 0, _numberArray.Length - 1);
            Console.WriteLine("Number of Comparisons: {0}", getNumberofComparisons());
        }

        //recursive partitioning algorithm for quick sort algorithm
        private void partitionArray(int[] numberArray, int l, int r)
        {
            if(l >= r) return;
            //choosing the median pivot
            int middleIndex = getMiddleIndex(l, r);
            int medianIndex = getMedianIndex(l, r, middleIndex);
            if (medianIndex < 0) return;

            swapArray(ref numberArray, l, medianIndex);
            if ((l - r) != (_numberArray.Length - 1))
            {
                _numberOfComparisons = _numberOfComparisons + (r - l);
            }
            int pivot = numberArray[l];
            int i = l + 1; 
            for (int j = i; j <= r; j++)
            {
                _numberOfComparisons++;
                if (numberArray[j] < pivot)
                {                    
                    swapArray(ref numberArray, j, i);
                    i = i + 1;
                }
            }
            swapArray(ref numberArray, l, i - 1);
            //partition left array
            partitionArray(numberArray, l, i - 2);
            //partition right array
            partitionArray(numberArray, i, r);
        }

        private void swapArray(ref int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        private int getMiddleIndex(int l, int r)
        {
            int arrayLength = l - r + 1;
            if (arrayLength % 2 == 0) return arrayLength / 2;
            else return (arrayLength + 1) / 2;
        }

        private int getMedianIndex(int first, int end, int middle)
        {
            int medianIndex = -1; 
            if ((first < end && first > middle) || (first > end && first < middle)) medianIndex = first;
            if ((end < first && end > middle) || (end > first && end < middle)) medianIndex = end;
            if ((middle < end && middle > first) || (middle > end && middle < first)) medianIndex = middle;
            return medianIndex;
        }

        public int getNumberofComparisons()
        {
            return _numberOfComparisons;
        }

    }
}
