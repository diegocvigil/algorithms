using System;
using System.Collections.Generic;

internal class Program
{
   static void Main(string[] args)
   {
      BinaryTree bt9 = new BinaryTree(10);
      BinaryTree bt8 = new BinaryTree(9);
      BinaryTree bt7 = new BinaryTree(8);
      BinaryTree bt6 = new BinaryTree(7);
      BinaryTree bt5 = new BinaryTree(6);
      BinaryTree bt4 = new BinaryTree(5);
      bt4.left = bt9;
      BinaryTree bt3 = new BinaryTree(4);
      bt3.left = bt7;
      bt3.right = bt8;
      BinaryTree bt2 = new BinaryTree(3);
      bt2.left = bt5;
      bt2.right = bt6;
      BinaryTree bt1 = new BinaryTree(2);
      bt1.left = bt3;
      bt1.right = bt4;
      BinaryTree bt0 = new BinaryTree(1);
      bt0.left = bt1;
      bt0.right = bt2;


      var result = BranchSums(bt0);

      foreach (var item in result)
      {
         Console.WriteLine(item);
      }

   }

   public static List<int> BranchSums(BinaryTree root)
   {
      return SumValues(root, new List<int>(), 0);
   }

   public static List<int> SumValues(BinaryTree root, List<int> branchSums, int branchSum)
   {

      branchSum += root.value;

      if (root.left == null && root.right == null)
      {
         branchSums.Add(branchSum);
         return branchSums;
      }


      if (root.left != null)
      {
         SumValues(root.left, branchSums, branchSum);
         if (root.right != null)
         {
            SumValues(root.right, branchSums, branchSum);
         }
      }
      else if (root.right != null)
      {
         SumValues(root.right, branchSums, branchSum);
         if (root.left != null)
         {
            SumValues(root.left, branchSums, branchSum);
         }
      }

      return branchSums;
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
      this.left = null;
      this.right = null;
   }
}