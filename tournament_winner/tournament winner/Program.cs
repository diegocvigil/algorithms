using System.Collections.Generic;
using System;

public static string TournamentWinner(List<List<string>> competitions, List<int> results)
{
   // Write your code here.
   Dictionary<string, int> res = new Dictionary<string, int>();

   for (int i = 0; i < results.Count; i++)
   {
      // if "1" means the home team won, so the Home team is in the index 0 
      // of the competitions' array
      if (results[i] == 1)
      {
         var winner = competitions[i][0];
         if (!res.ContainsKey(winner))
         {
            res.Append(new KeyValuePair<string, int>(winner, 3));
         }
         else
         {
            int value = 0;
            res.TryGetValue(winner, out value);
            value += 3;
            res[winner] = value;
         }
      }
      // if "0" means the away team won, so the Away team is in the index 1
      // of the competitions' array
      else if (results[i] == 0)
      {
         var winner = competitions[i][1];
         if (!res.ContainsKey(winner))
         {
            res.Append(new KeyValuePair<string, int>(winner, 3));
         }
         else
         {
            int value = 0;
            res.TryGetValue(winner, out value);
            value += 3;
            res[winner] = value;
         }
      }

   }

   string winnerName = "";
   int winnerPoints = 0;
   foreach (var item in res)
   {
      if (item.Value > winnerPoints)
      {
         winnerPoints = item.Value;
         winnerName = item.Key;
      }
   }

   return winnerName;
}

var competitions = [

  ["HTML", "C#"],

  ["C#", "Python"],

  ["Python", "HTML"],
   ];

var results = [0, 0, 1];

Console.WriteLine(TournamentWinner(competitions, results));

