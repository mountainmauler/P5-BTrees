//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - B-Trees
//	File Name:		Driver.cs
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5 {
    static class Driver {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BTreeMenuForm());
        }
    }
}
