using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GraphsLibrary
{
    public class Graph
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
            String line;
            int count = 0;
            try
            {
                StreamReader file = new StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {                    
                    string[] connectedVertices = line.Split(new Char[] { '\t' });
                    
                     
                    Vertex vertex = new Vertex(); 
                    vertex.Id = (Int32.Parse(connectedVertices[0]));
                    if (uniqueVertex(vertex)) _vertices.Add(vertex);
                    for (int i = 1; i < connectedVertices.Length - 1; i++)          // Length - 1 because the every line has a empty tab at the end of the line
                    {
                        Vertex connectedVertex = new Vertex();
                        connectedVertex.Id = (Int32.Parse(connectedVertices[i]));
                        Edge connectingEdge = new Edge(vertex, connectedVertex);
                        if (uniqueVertex(vertex) || uniqueVertex(connectedVertex))
                        {
                            _vertices.Add(connectedVertex);
                            connectingEdge.Id = (count);
                            _edges.Add(connectingEdge);
                            vertex.VEdge = (connectingEdge);
                            connectedVertex.VEdge = (connectingEdge);
                            count++;
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Write("File not found");
            }
            catch (FormatException e)
            {
                Console.WriteLine("String formatting Error");
            }
        }

        //check if the vertex is unique in the list or not
        private bool uniqueVertex(Vertex vertex)
        {
            foreach (Vertex vItem in _vertices)
            {
                if (vItem.Id == vertex.Id) return false;
            }
            return true;
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
