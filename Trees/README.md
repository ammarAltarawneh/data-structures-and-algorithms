# Trees

## Introduction
A Binary Search Tree is a binary tree where each node has at most two children (left and right), and the left child's value is less than the node's value, while the right child's value is greater. The BinarySearchTree class provided in this project is a specialized version of the BinaryTree class, optimized for fast searching and insertion operations.


## Classes
1- Node:

The Node class represents a single node in the binary tree. It contains properties for the node's value, left child, and right child.

2- BinaryTree:

The BinaryTree class represents a basic binary tree. It provides methods for performing depth-first traversals: pre-order, in-order, and post-order. Each traversal returns a list of node values in the respective order.

3- BinarySearchTree:

The BinarySearchTree class is a subclass of BinaryTree. It extends the basic binary tree functionality with two additional methods: Add and Contains.
Add(value): Adds a new node with the given value to the binary search tree in the correct location.
Contains(value): Checks if the value exists in the binary search tree at least once and returns a boolean indicating its presence.