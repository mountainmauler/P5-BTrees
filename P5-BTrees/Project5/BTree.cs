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
        /// The 'M' value in a 'M-ary' tree.
        /// </summary>
        public byte Arity { get; set; }

        /// <summary>
        /// The 'M-ary' B-Tree which is made up of a list of indexes -- each index contains a list of nodes which
        ///  also can or cannot be indexes as well.
        /// </summary>
        public List<Index> Tree { get; private set; }

        /// <summary>
        /// Default constructor for the <see cref="BTree"/> class.
        /// </summary>
        public BTree() {
        }//end BTree()

        /// <summary>
        /// Parameterized constructor for the <see cref="BTree"/> class. Sets the 'arity' of the new B-Tree.
        /// </summary>
        /// <param name="m">The 'arity' -- 'M-ary' M value -- of the new tree.</param>
        public BTree(byte m) {
            Arity = m;              //Arity is set to passed value m
        }//end BTree(byte)
    }//end BTree
}
