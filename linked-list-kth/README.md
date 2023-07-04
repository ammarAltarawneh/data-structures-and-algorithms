# Linked List Kth

## Kth from the End

**Whitboard:**
![](Untitled%20(7).jpg)

## Approach & Efficiency:
I used a single linked list approach to find the kth-to-last element. By looping through the linked list once to calculate its length and another loop to check if the counter is equal to (length - k), I can return the value for the desired node. In the worst case, this method has a time complexity of O(n) and a space complexity of O(1).

## Stretch Goal Middle Number:
I used a loop to iterate through the linked list, obtaining its length. Then, I used another loop to find the middle node by comparing the length divided by 2 with a counter (i). If the condition is true, I return the node value. Otherwise, I increment the counter and move to the next node.

The time complexity (Big O) of this approach is O(n), and the space complexity is O(1).
