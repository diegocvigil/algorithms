using System;
using System.Collections.Generic;

internal class Program
{
   static void Main(string[] args)
   {
      var root = new BinaryTree(1);
      root.left = new BinaryTree(2);
      root.left.left = new BinaryTree(4);
      root.left.left.left = new BinaryTree(8);
      root.left.left.right = new BinaryTree(9);
      root.left.right = new BinaryTree(5);
      root.right = new BinaryTree(3);
      root.right.left = new BinaryTree(6);
      root.right.right = new BinaryTree(7);

      var result = NodeDepths2(root);
      Console.WriteLine(result);
   }

   public static int NodeDepths(BinaryTree root)
   {
      // Write your code here.
      return NodeDepths(root, 0);

   }

   // Using recursive calls
   // O(n) time complexity | O(h) space complexity where h equals depth's tree
   public static int NodeDepths(BinaryTree root, int nextIndex)
   {
      // Write your code here.
      if (root == null) return 0;
      return nextIndex + NodeDepths(root.left, nextIndex + 1) + NodeDepths(root.right, nextIndex + 1);
   }

   // Using interative calls
   // O(n) time complexity | O(h) space complexity where h equals depth's tree
   public static int NodeDepths2(BinaryTree root)
   {
      // Write your code here.
      Stack<BinaryTreeLevel> nodes = new Stack<BinaryTreeLevel>();
      nodes.Push(new BinaryTreeLevel(root, 0));

      int sumNodesValue = 0;

      while(nodes.Count > 0)
      {
         var node = nodes.Pop();
         sumNodesValue += node.level;

         if(node.node.left != null) nodes.Push(new BinaryTreeLevel(node.node.left, node.level + 1));
         if(node.node.right != null) nodes.Push(new BinaryTreeLevel(node.node.right, node.level + 1));
      }

      return sumNodesValue;
   }

   public class BinaryTreeLevel
   {
      public BinaryTree node;
      public int level;

      public BinaryTreeLevel(BinaryTree node, int level)
      {
         this.node = node;
         this.level = level;
      }
   }

   public class BinaryTree
   {
      public int value;
      public BinaryTree left;
      public BinaryTree right;

      public BinaryTree(int value)
      {
         this.value = value;
         left = null;
         right = null;
      }
   }
}