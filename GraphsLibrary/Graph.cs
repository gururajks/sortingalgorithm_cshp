using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsLibrary
{
    class Graph
    {
        private ArrayList _vertices;
        private ArrayList _edges;

        public Graph(String filePath) 
        {
            _vertices = new ArrayList();
            _edges = new ArrayList();
            readIntoGraph(filePath);
        }

        //Reads in a file to get the vertices and the edges for the graph
        private void readIntoGraph(String filePath)
        {

        }


        //Get vertices array
        public ArrayList getVertices()
        {
            return _vertices;
        }

        //Get edges array
        public ArrayList getEdges()
        {
            return _edges;
        }
    }
}
