using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The minimum cut calculator works on the contraction algorithm 
 * The algorithm uses a recursive method to reduce the number of vertices constantly to calculate 
 * the minimum cut of the graph.
 * It picks random edges for contraction, so a number of trials is needed to gurantee a reliable answer
 */

namespace GraphsLibrary
{
    public class MinCutCalculator
    {
        Graph graph;
        public MinCutCalculator(Graph graph)
        {
            this.graph = graph;
        }








    }
}
