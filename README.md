## P5-BTrees
### 'Project 5 - B-Trees' current progress...

- [X] Create all base classes that will be used in the program
- [ ] Write the code for the BTree class
  - Use recursion when it is practical and simplifies the code of any of BTree's methods
  - Other data structures -- List, Stack, Queue, PriorityQueue, ... -- can be used if it is needed
   - [ ] Adding values
     - Allow for splitting Leaf and Index nodes to insert a value if needed
   - [ ] Displaying the B-Tree
     - Display as a Pre-Order traversal -- parent node before the child
   - [ ] Gathering statistics
- [ ] Write the code for the Driver class
  - [ ] Builds a BTree populated with 500 uniformly distributed random integers -- 0-9999
    - The "Nodes" at each level should have room for **N** values. 
    - When a Node is already full, and the insertion of a new item into it must be made, split the Node into two separate Nodes each with at least half of the slots filled -- _((N + 1) / 2)_
 - [ ] Design the layout and write the event handling code for the BTreeMenu class
   - The GUI that is created must allow the following:
     - Set the "arity" of a new tree and create the tree
     - Populate the tree with 500 uniformly distributed **_unique_** random integers
     - Display the tree in a reasonable manner
       - Its output should be designed and labeled appropriately due to the size of the tree
       - Statistics pertaining to its depth, percent filled, number of index or leaf nodes, etc.
     - Add a new user-specified integer value to the BTree
     - Find a value and display its entire node if it is present or an appropriate error message if it is not present
       - Display the nodes visited in the search for the node containing the specified value

###### *Created in C# with Microsoft Visual Studio 2015, Enterprise Edition.*
