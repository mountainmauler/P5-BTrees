//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - B-Trees
//	File Name:		BTree.cs
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
    class BTree {
        /// <summary>
        /// The number of all nodes that are currently in the B-Tree.
        /// </summary>
        public int NodeCount { get; set; }
        /// <summary>
        /// The number of index nodes that are currently in the B-Tree.
        /// </summary>
        public int IndexCount { get; set; }
        /// <summary>
        /// The number of leaf nodes that are currently in the B-Tree. 
        /// </summary>
        public int LeafCount { get; set; }
        /// <summary>
        /// The node size value, or 'arity', corresponding to the 'M' in this 'M-ary' tree.
        /// </summary>
        public int NodeSize { get; set; }
        /// <summary>
        /// The root node of the B-Tree.
        /// </summary>
        public Node RootNode { get; set; }
        /// <summary>
        /// A list of the index nodes that are currently in the B-Tree.
        /// </summary>
        public List<Index> TreeIndex { get; set; }
        /// <summary>
        /// A list of the leaf nodes that are currently in the B-Tree.
        /// </summary>
        public List<Leaf> TreeLeaf { get; set; }

        /// <summary>
        /// Parameterized constructor for the <see cref="BTree"/> class.
        /// </summary>
        /// <param name="max">The size of each node in the B-Tree.</param>
        public BTree(int max) {
            NodeSize = max;                 //Size is set to passed value 'max'
            RootNode = new Node(NodeSize);  //RootNode is set to a new node of the set maximum node size
            TreeIndex = null;               //TreeIndex is set to null
            TreeLeaf = null;                //TreeLeaf is set to null
        }//end BTree(int)
    }//end BTree
}