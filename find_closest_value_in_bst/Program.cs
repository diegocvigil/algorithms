using System;


internal class Program
{
   static void Main(string[] args)
   {
      var root = new BinaryTree(10);
      root.left = new BinaryTree(5);
      root.left.left = new BinaryTree(2);
      root.left.left.left = new BinaryTree(1);
      root.left.right = new BinaryTree(5);
      root.right = new BinaryTree(15);
      root.right.left = new BinaryTree(13);
      root.right.left.right = new BinaryTree(14);
      root.right.right = new BinaryTree(22);

      var result = FindClosestValueInBinaryTree(root, 12);
      Console.WriteLine(result);
   }

   public static int FindClosestValueInBinaryTree(BinaryTree tree, int target)
   {
      // return FindClosestValueInBinaryTree(tree, target, tree.value);

      return FindClosestValueInBinaryTreeOptimal(tree, target, tree.value);
   }

   // Average: O (log n) time | O (log n) space
   // Worst:   O (n) time     | O (n) space
   // This is a non-optimal algorithm because it's using recursive function
   // and this method uses more space complexity because each call
   // to the function create a new layer on the stack
   public static int FindClosestValueInBinaryTree(BinaryTree tree, int target, int closest)
   {
      if (tree == null) return closest;

      if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
      {
         closest = tree.value;
      }

      if (target > tree.value)
      {
         return FindClosestValueInBinaryTree(tree.right, target, closest);
      }
      else if (target < tree.value)
      {
         return FindClosestValueInBinaryTree(tree.left, target, closest);
      }
      else
      {
         return closest;
      }
   }

   // ----------------------------------------------------------
   // Average: O (log n) time | O (log n) space
   // Worst:   O (n) time     | O (1) space
   // ----------------------------------------------------------
   // This is an optimal algorithm because it iterates through 
   // the values without creating new layers on stack
   // ----------------------------------------------------------
   public static int FindClosestValueInBinaryTreeOptimal(BinaryTree tree, int target, int closest)
   {
      BinaryTree currentNode = tree;

      while (currentNode != null)
      {
         if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value))
         {
            closest = currentNode.value;
         }

         if (target > currentNode.value)
         {
            currentNode = currentNode.right;
         }
         else if (target < currentNode.value)
         {
            currentNode = currentNode.left;
         }
         else
         {
            break;
         }
      }

      return closest;
   }

   public class BinaryTree
   {
      public int value;
      public BinaryTree left;
      public BinaryTree right;

      public BinaryTree(int value)
      {
         this.value = value;
      }
   }
}