//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - B-Trees
//	File Name:		Index.cs
//	Description:	The Index class -- derived from the Node base class -- that governs all operations and values
//                   related to each row
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
    class Index : Node {
        /// <summary>
        /// The children nodes, either index or leaf nodes, for this specific index node in the B-Tree.
        /// </summary>
        public List<Node> Children { get; set; }

        /// <summary>
        /// Default constructor for the <see cref="Index"/> class. Calls <see cref="Node"/>'s default constructor.
        /// </summary>
        public Index() {
        }//end Index()
    }//end Index : Node
}
