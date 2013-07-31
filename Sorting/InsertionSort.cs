using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort : Sort
    {
        public InsertionSort(int[] numberArray)
        {
            this._numberArray = numberArray;
        }

        //Implementing insertion sort algorithm
        public override void implementSort()
        {
            startTime();
            int[] tempArray = new int[_numberArray.Length];
            for (int i = 0; i < _numberArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (_numberArray[i] < tempArray[j])
                    {
                        moveElements(j + 1, i, tempArray);
                        tempArray[j] = _numberArray[i];
                    }
                }
            }
            tempArray.CopyTo(_numberArray, 0);
            endTime(); 
        }

        private void moveElements(int left_range, int right_range, int[] tempArray)
        {
            for (int x = right_range - 1; x >= left_range - 1; x--)
            {
                tempArray[x + 1] = tempArray[x];
            }
        }

     

        

    }
}
