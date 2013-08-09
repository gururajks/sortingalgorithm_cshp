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
            for (int i = 1; i < _numberArray.Length; i++)
            {
                int valueToBeInserted = _numberArray[i];
                int indexPosition = i;
                while (_numberArray[i] < _numberArray[indexPosition-1])
                {
                    _numberArray[indexPosition] = _numberArray[indexPosition - 1];
                    indexPosition = indexPosition - 1;
                }
                _numberArray[indexPosition] = valueToBeInserted;
            }
            endTime(); 
        } 

       
    }
}
