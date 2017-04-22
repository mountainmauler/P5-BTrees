//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - B-Trees
//	File Name:		Node.cs
//	Description:	The base class that the Index and Leaf classes are derived from by using subtype polymorphism.
//                   Contains the list of integer values stored in the node grouping as well as each group's size.
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
        /// The node size value of the B-Tree -- dictates how many nodes are in each index or leaf.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Default constructor for the <see cref="Node"/> class.
        /// </summary>
        public Node() {
            NodeValue = null;               //Set NodeValue to null
            Size = -1;                      //Set Size to -1 (null)
        }//end Node()

        /// <summary>
        /// Parameterized constructor for the <see cref="Node"/> class. Sets this node's group size.
        /// </summary>
        /// <param name="size">The integer value to be stored as the node's group size.</param>
        public Node(int size) {
            Size = size;                    //Set Size to the passed integer parameter 'size'
            NodeValue = new List<int>();    //Set NodeValue list to a new List<int> object
        }//end Node(int, Node)

        /// <summary>
        /// Returns all of the integer values in this node grouping as a string.
        /// </summary>
        /// <returns>The string containing all node group values.</returns>
        public override string ToString() {
            string returnString = String.Empty;
            foreach (int i in NodeValue)
                returnString += i + " ";
            return (returnString);
        }//end ToString()
    }//end Node
}
