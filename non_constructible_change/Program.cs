using System;

internal class Program
{
   static void Main(string[] args)
   {
      int result = 0;
      result = NonConstructibleChange(new int[] { 5, 7, 1, 1, 2, 3, 22 });
      Console.WriteLine(result);

      result = NonConstructibleChange(new int[] { 1, 2, 4 });
      Console.WriteLine(result);

      result = NonConstructibleChange(new int[] { 1, 1, 3, 7 });
      Console.WriteLine(result);
   }
   public static int NonConstructibleChange(int[] coins)
   {
      // Write your code here.
      Array.Sort(coins);

      int currentChange = 0;

      foreach (int coin in coins)
      {
         if(coin > currentChange + 1) return (currentChange + 1);

         currentChange += coin;
      }

      return currentChange + 1;
   }
}