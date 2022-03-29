def minimumWaitingTime(queries):
   queries.sort()
   sumQueryTime = 0
   for idx, queryTime in enumerate(queries):
      leftQueries = len(queries) - (idx + 1)
      sumQueryTime += leftQueries * queryTime
   
   return sumQueryTime

queries = [3, 2, 1, 2, 6]
print(minimumWaitingTime(queries))