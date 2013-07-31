using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort : Sort
    {
        
        public BubbleSort(int[] numberArray)
        {            
            this._numberArray = numberArray;
        }
                        
        //Implementing bubble sort algorithm
        public override void implementSort()
        {
            startTime();
            int noSwap = 0;
            while (noSwap == 0)
            {
                noSwap = 1;
                for (int i = 0; i < _numberArray.Length - 1; i++)
                {
                    if (_numberArray[i] > _numberArray[i + 1])
                    {
                        swapArrays(i, i + 1);
                        noSwap = 0;
                    }
                }
            }
            endTime();
        }

        private void swapArrays(int left, int right)
        {
            int temp = _numberArray[left];
            _numberArray[left] = _numberArray[right];
            _numberArray[right] = temp;
        }
        
    }
}
