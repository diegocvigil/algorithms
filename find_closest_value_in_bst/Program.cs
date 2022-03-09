using System;


internal class Program
{
   static void Main(string[] args)
   {
      var root = new BST(10);
      root.left = new BST(5);
      root.left.left = new BST(2);
      root.left.left.left = new BST(1);
      root.left.right = new BST(5);
      root.right = new BST(15);
      root.right.left = new BST(13);
      root.right.left.right = new BST(14);
      root.right.right = new BST(22);

      var result = FindClosestValueInBst(root, 12);
      Console.WriteLine(result);
   }

   public static int FindClosestValueInBst(BST tree, int target)
   {
      // return FindClosestValueInBst(tree, target, tree.value);

      return FindClosestValueInBstOptimal(tree, target, tree.value);
   }

   // Average: O (log n) time | O (log n) space
   // Worst:   O (n) time     | O (n) space
   // This is a non-optimal algorithm because it's using recursive function
   // and this method uses more space complexity because each call
   // to the function create a new layer on the stack
   public static int FindClosestValueInBst(BST tree, int target, int closest)
   {
      if (tree == null) return closest;

      if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
      {
         closest = tree.value;
      }

      if (target > tree.value)
      {
         return FindClosestValueInBst(tree.right, target, closest);
      }
      else if (target < tree.value)
      {
         return FindClosestValueInBst(tree.left, target, closest);
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
   public static int FindClosestValueInBstOptimal(BST tree, int target, int closest)
   {
      BST currentNode = tree;

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

   public class BST
   {
      public int value;
      public BST left;
      public BST right;

      public BST(int value)
      {
         this.value = value;
      }
   }
}