using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using GraphsLibrary;


namespace CutFinder
{
    public class MinCutFinder
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph("C:/Users/Gururaj/Documents/Visual Studio 2012/kargerMinCut.txt");
            ArrayList edges = graph.getEdges();
            foreach (Edge edge in edges)
            {
                Console.WriteLine(edge.Id);
            }

             
            Console.ReadLine();
        }
    }
}
