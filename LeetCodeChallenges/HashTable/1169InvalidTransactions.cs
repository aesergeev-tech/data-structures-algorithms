namespace HashTable;

public partial class Solution
{
    public class Transaction
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public int Amount { get; set; }
        public string City { get; set; }

        public Transaction(string str)
        {
            var parts = str.Split(",");
            Name = parts[0];
            Time = int.Parse(parts[1]);
            Amount = int.Parse(parts[2]);
            City = parts[3];
        }

        public override string ToString()
        {
            return $"{Name},{Time},{Amount},{City}";
        }
    }

    public IList<string> InvalidTransactions(string[] transStrs)
    {
        var transactions = transStrs.Select(x => new Transaction(x)).ToList();

        var map = new Dictionary<string, List<Transaction>>();
        var result = new List<string>();

        foreach (var trans in transactions)
        {
            if (trans.Amount > 1000)
            {
                result.Add(trans.ToString());
            }
            else
            {
                if (map.TryGetValue(trans.Name, out var sameNameTransactions))
                {
                    foreach (var snT in sameNameTransactions)
                    {
                        if (Math.Abs(snT.Time - trans.Time) <= 60 && snT.City.Equals(trans.City) == false)
                        {
                            result.Add(trans.ToString());
                            result.Add(snT.ToString());
                        }
                    }

                    map[trans.Name].Add(trans);
                }
                else
                {
                    map[trans.Name] = new List<Transaction>() { trans };
                }
            }
        }

        return result;
    }
}