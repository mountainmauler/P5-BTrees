//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - B-Trees
//	File Name:		Node.cs
//	Description:	
//	Course:			CSCI 2210-002 - Data Structures
//	Author:			Christopher Cobb, cobbcl@etsu.edu; Brent Baker, bakerba3@etsu.edu;
//	Created:		Sunday, April 16, 2017
//	Copyright:		Christopher Cobb, Brent Baker (2017)
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5 {
    /// <summary>
    /// The base <see cref="Node"/> class from which the <see cref="Index"/> and <see cref="Leaf"/> classes are
    ///  derived.
    /// </summary>
    class Node {
        /// <summary>
        /// A list of unique values that have been stored in this node grouping.
        /// </summary>
        public List<int> NodeValue { get; set; }
        /// <summary>
        /// The 'arity' of the B-Tree which dictates how many nodes are in each index row or leaf column.
        /// </summary>
        public int NodeSize { get; set; }

        /// <summary>
        /// Default constructor for the <see cref="Node"/> class.
        /// </summary>
        public Node() {
            NodeValue = null;       //Set NodeValue to null
            NodeSize = -1;          //Set NodeSize to -1 (null)
        }//end Node()

        /// <summary>
        /// Parameterized constructor for the <see cref="Node"/> class. Sets this node's group size.
        /// </summary>
        /// <param name="size">The integer value to be stored as the node's group size.</param>
        public Node(int size) {
            NodeSize = size;        //Set NodeSize to the passed integer parameter 'size'
        }//end Node(int, Node)
    }//end Node
}
