using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsLibrary
{
    public class Edge
    {
        int _id;           //Edge id
        Vertex _vertex1;   //First Vertex
        Vertex _vertex2;   //second vertex for the edge

        public Edge(Vertex vertex1, Vertex vertex2)
        {
            _vertex1 = vertex1;
            _vertex2 = vertex2;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
            }
        }
    } 

     
    public class EdgeFactory
    {


    }
}
