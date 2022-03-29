# Algorithm
### Calculate the sum of the node's Depths of a Tree (Binary Tree)

**Goal** : Sum the node's depth of a tree

#### There are 2 methods for this

- The first one is using recursivity. O(n) time complexity | O(h) space complexity where h is the tree's depth. Sum the node level from the current node, plus the result of function passing the left child node and incrementing the level (since it's the next level), plus the result of function passing the right child node and incrementing the level (since it's the next level)

- The second one is iterating through the tree's values. O(n) time complexity | O(h) space complexity where h is the tree's depth. The root node is added to a stack data structure, the node is poped out from it and added to a variable, if it has left and right child nodes they are added to the stack and another node is poped out again and the value is added if it has left and right nodes they are pushed to the stack and so on