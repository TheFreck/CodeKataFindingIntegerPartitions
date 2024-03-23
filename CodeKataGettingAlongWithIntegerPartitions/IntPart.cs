using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataGettingAlongWithIntegerPartitions
{
    public class IntPart
    {
        public static string Part(long n)
        {
            var partitions = Partition(n);
            var products = new List<long>();
            partitions.ForEach(p => products.Add(FindProduct(p)));
            products.OrderBy(a => a);
            return GetStats(products.OrderBy(a => a).ToList());
        }

        public static List<List<long>> Partition(long input)
        {
            var partitionSet = new Dictionary<long, List<List<long>>>
            {
                { 
                    1, new List<List<long>>
                    {
                        new List<long> { 1 },
                    }
                },
                {
                    2, new List<List<long>>
                    {
                        new List<long> { 2 },
                        new List<long> { 1,1 }
                    }
                }
            };
            for(var i=3; i<=input; i++)
            {
                var partsToTry = new List<List<long>> ();
                for (var j=1; j<=i; j++)
                {
                    if (j <= i - j)
                        partsToTry.Add(new List<long> { i - j, j });
                }
                var getParts = UpdatePartitionSet(partitionSet, i, partsToTry);

                partitionSet.Add(i, getParts);
            }
            return partitionSet[input].ToList();
        }

        public static List<List<long>> UpdatePartitionSet(Dictionary<long, List<List<long>>> set, long input, List<List<long>> parts)
        {
            var innerSet = new Dictionary<long, List<List<long>>>(set);
            var setList = new List<List<long>> { new List<long> { input } };
            for(var i=0; i<parts.Count; i++)
            {
                var firstSet = innerSet[parts[i][0]].ToList();
                for(var j=0; j < firstSet.Count; j++)
                {
                    var newList = firstSet[j].ToList();
                    newList.Add(parts[i][1]);
                    setList.Add(newList.OrderByDescending(a => a).ToList());
                }
            }
            return RemoveDuplicates(setList);
        }

        public static List<List<long>> RemoveDuplicates(List<List<long>> input)
        {
            var hash = new HashSet<string>();
            for(var i=0; i<input.Count; i++)
            {
                hash.Add(string.Join(",",input[i]));
            }
            var output = new List<List<long>>();
            for(var i=0; i<hash.Count; i++)
            {
                var intList = new List<long>();
                hash.ToList()[i].Split(',').ToList().ForEach(s => intList.Add(long.Parse(s)));
                output.Add(intList);
            }
            return output;
        }

        public static long FindProduct(List<long> input)
        {
            long output = 1;
            foreach(var i in input)
            {
                output *= i;
            }
            return output;
        }

        public static string GetStats(List<long> input)
        {
            float range = Math.Abs(input.FirstOrDefault() - input.LastOrDefault());
            float mean = (float)Math.Round((float)input.Sum() / input.Count,2);
            var upperIndx = 0;
            var lowerIndx = 0;
            if(input.Count%2 == 0)
            {
                upperIndx = input.Count/2-1;
                lowerIndx = input.Count/2;
            }
            else
            {
                upperIndx = input.Count/2;
                lowerIndx = input.Count/2;
            }
            var numerator = (input[lowerIndx] + input[upperIndx]);
            float median = ((float)input[lowerIndx] + (float)input[upperIndx]) / 2.0f;
            return $"Range: {range} Average: {mean.ToString("0.00")} Median: {median.ToString("0.00")}";
        }
    }
}