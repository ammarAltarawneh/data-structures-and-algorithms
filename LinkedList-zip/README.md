# Linked List Zip

**Whitboard:**
![](./Untitled%20(8).jpg)

## Approach:
The approach for the ZipLists program is to iteratively traverse the two linked lists, list1 and list2, and interleave their nodes to create a new zipped list. The algorithm has the following steps:

Check if either list1 or list2 is empty. If one of them is empty, return the other list as the zipped list.

Create two pointers, current1 and current2, and initialize them to the heads of list1 and list2.

Traverse through the lists in parallel while both current1 and current2 are not null:

Store the next nodes in next1 and next2.
Update current2.Next to point to next1.
Update current1.Next to point to current2.
Move current1 to next1 and current2 to next2.
Handle the case where one list is longer than the other:

If current1 is null, connect the remaining nodes of list2 to the tail of list1 and update the tail.
If current2 is null, no further action is needed.
Return the head of list1 as the zipped list.

## Efficiency:

Time Complexity: O(n), where n is the total number of nodes in both list1 and list2. The algorithm iterates through the lists once, zipping the nodes together in an alternating manner.
Space Complexity: O(1). The algorithm uses a constant amount of additional space to store temporary variables and pointers, regardless of the input list size.
Overall, the approach and efficiency of the ZipLists program aim to efficiently interleave the nodes of two linked lists into a new zipped list with a low space complexity.