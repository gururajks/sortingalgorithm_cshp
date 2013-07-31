using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class Sort
    {
        protected int[] _numberArray;
        protected Stopwatch _stopWatch;
                        
        /*To calculate the time taken for an algorithm */
        protected void startTime()
        {
            _stopWatch = new Stopwatch();
            _stopWatch.Start();
        }

        protected void endTime()
        {
            _stopWatch.Stop();
        }

        //Returns the elapsed time in seconds
        public long elapsedTime()
        {
            if(_stopWatch != null)
                return _stopWatch.ElapsedMilliseconds;
            return 0;
        }

        public int[] getSortedArray()
        {
            return _numberArray;
        }

        /*Abstract methods */

        //Abstract method that gets overriden by derived classes
        //Each sorting algorithm has its sorting algorithm
        public abstract void implementSort();

    }
}
