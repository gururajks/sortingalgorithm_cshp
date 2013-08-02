using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Sorting;

namespace SortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int count = 0;            
            int[] numbers = new int[100000];
            StreamReader file = new StreamReader("C:/Users/Gururaj/Documents/Visual Studio 2012/IntegerArray.txt");
            while ((line = file.ReadLine()) != null)
            {
                numbers[count] = Int32.Parse(line);
                count++;
            }

            Sort sortArray = new SelectionSort(numbers);
            sortArray.implementSort();
            int[] sortedArray = sortArray.getSortedArray();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write("{0} ", sortedArray[i]);
            }
            Console.WriteLine();
            Console.Write("Elapsed Time - Insertion Sort: {0}", sortArray.elapsedTime());
            Console.ReadLine();
        }
    }
}
