using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort : Sort
    {
        public SelectionSort(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        //Selection sort algorithm 
        //Takes the smallest value in the unsorted array and adds into the sorted array in increasing order
        public override void implementSort()
        {
            startTime();
            for (int i = 0; i < _numberArray.Length; i++)
            {
                for (int j = i + 1; j < _numberArray.Length; j++)
                {
                    if (_numberArray[i] > _numberArray[j])
                    {
                        int temp = _numberArray[i];
                        _numberArray[i] = _numberArray[j];
                        _numberArray[j] = temp;
                    }
                }
            }
            endTime();
        }

    }
}
