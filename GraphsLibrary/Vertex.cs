using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsLibrary
{
    public class Vertex
    {
        int _id;            //Id for the node/vertex
        Edge memberEdge;    //Member variable for the vertex

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

        public Edge VEdge 
        {
            get
            {
                return memberEdge;
            }
            set 
            {
                memberEdge = value;
            }
        }

    }

    public class VertexFactory
    {

    }
}
