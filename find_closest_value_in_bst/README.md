# Algorithm
### Find Closest Value In BinaryTree (Binary Search Tree)

**Goal** : Find the node with closest value based on the target value.

#### There are 2 methods for this
- The first one is using recursivity, but this is a non-optimal algorithm because it will create layers on the stack and the Space Complexity will be O(log n) on Average or O(n) on worst case.
- The second one is iterating through the tree's values. This will not add frames to the call stack. And so that means we are not using extra memory.