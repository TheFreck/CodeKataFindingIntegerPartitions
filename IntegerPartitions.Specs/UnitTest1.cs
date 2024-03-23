using CodeKataGettingAlongWithIntegerPartitions;
using Machine.Specifications;
using System.Collections.Concurrent;
using System.Runtime;

namespace IntegerPartitions.Specs
{
    public class When_Partition_2
    {
        Establish context = () =>
        {
            input = 2;
            expect = new List<List<long>>
                {
                    new List<long>{ 2},
                    new List<long>{ 1,1 }
            };
        };

        Because of = () => answer = IntPart.Partition(input);

        It Should_Return_Correct_Number_Of_Sets = () =>
        {
            for (var i = 0; i < expect.Count; i++)
            {
                answer[i].Count.ShouldEqual(expect[i].Count);
                for (var j = 0; j < expect[i].Count; j++)
                {
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        It Should_Return_Partitions_For_One_And_Two_And_Three = () =>
        {
            for (var i = 0; i < expect.Count; i++)
            {
                for (var j = 0; j < expect[i].Count; j++)
                {
                    if (answer[i][j] != expect[i][j] || j == expect[i].Count - 1)
                    {
                        var ans = answer[i][j];
                        var exp = expect[i][j];
                    }
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        private static int input;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Partition_3
    {
        Establish context = () =>
        {
            input = 3;
            expect = new List<List<long>>
                {
                    new List<long>{ 3 },
                    new List<long>{ 2,1 },
                    new List<long>{ 1,1,1 }
            };
        };

        Because of = () => answer = IntPart.Partition(input);

        It Should_Return_Correct_Number_Of_Sets = () =>
        {
            for (var i = 0; i < expect.Count; i++)
            {
                answer[i].Count.ShouldEqual(expect[i].Count);
                for (var j = 0; j < expect[i].Count; j++)
                {
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        It Should_Return_Partitions_For_One_And_Two_And_Three = () =>
        {
            for (var i = 0; i < expect.Count; i++)
            {
                for (var j = 0; j < expect[i].Count; j++)
                {
                    if (answer[i][j] != expect[i][j] || j == expect[i].Count - 1)
                    {
                        var ans = answer[i][j];
                        var exp = expect[i][j];
                    }
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        private static int input;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Partition_4
    {
        Establish context = () =>
        {
            input = 4;
            expect = new List<List<long>>
                {
                    new List<long>{ 4 },
                    new List<long>{ 3,1 },
                    new List<long>{ 2,1,1 },
                    new List<long>{ 1,1,1,1 },
                    new List<long>{ 2,2 },
            };
        };

        Because of = () => answer = IntPart.Partition(input);

        It Should_Return_Partitions_For_One_And_Two_And_Three = () =>
        {
            for (var i = 0; i < expect.Count; i++)
            {
                for (var j = 0; j < expect[i].Count; j++)
                {
                    if (answer[i][j] != expect[i][j] || j == expect[i].Count - 1)
                    {
                        var ans = answer[i][j];
                        var exp = expect[i][j];
                    }
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        private static int input;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Partition_5
    {
        Establish context = () =>
        {
            input = 5;
            expect = new List<List<long>>
            {
                new List<long>{ 5 },
                new List<long>{ 4,1 },
                new List<long>{ 3,1,1 },
                new List<long>{ 2,1,1,1 },
                new List<long>{ 1,1,1,1,1 },
                new List<long>{ 2,2,1 },
                new List<long>{ 3,2 },
            };
        };

        Because of = () => answer = IntPart.Partition(input);

        It Should_Return_Partitions_For_One_And_Two_And_Three = () =>
        {
            for (var i = 0; i < expect.Count; i++)
            {
                for (var j = 0; j < expect[i].Count; j++)
                {
                    if (answer[i][j] != expect[i][j] || j == expect[i].Count - 1)
                    {
                        var ans = answer[i][j];
                        var exp = expect[i][j];
                    }
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        private static int input;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Partition_6
    {
        Establish context = () =>
        {
            input = 6;
            expect = new List<List<long>>
            {
                new List<long>{ 6 },
                new List<long>{ 5,1 },
                new List<long>{ 4,1,1},
                new List<long>{ 3,1,1,1 },
                new List<long>{ 2,1,1,1,1 },
                new List<long>{ 1,1,1,1,1,1 },
                new List<long>{ 2,2,1,1 },
                new List<long>{ 3,2,1 },
                new List<long>{ 4,2 },
                new List<long>{ 2,2,2 },
                new List<long>{ 3,3 },
            };
        };

        Because of = () => answer = IntPart.Partition(input);

        It Should_Return_Partitions_For_One_And_Two_And_Three = () =>
        {
            for (var i = 0; i < expect.Count; i++)
            {
                for (var j = 0; j < expect[i].Count; j++)
                {
                    if (answer[i][j] != expect[i][j] || j == expect[i].Count - 1)
                    {
                        var ans = answer[i][j];
                        var exp = expect[i][j];
                    }
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        private static int input;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Updating_Partition_Set_For_3
    {
        Establish context = () =>
        {
            set = new Dictionary<long, List<List<long>>>
            {
                { 
                    2, new List<List<long>>
                    {
                        new List<long> { 2 },
                        new List<long> { 1,1 },
                    }
                }
            };
            input = 3;
            parts = new List<List<long>> 
            { 
                new List<long>{ 2, 1 },
            };
            expect = new List<List<long>>
            {
                new List<long> { 3 },
                new List<long> { 2,1 },
                new List<long> { 1,1,1 }
            };
        };

        Because of = () => answer = IntPart.UpdatePartitionSet(set, input, parts).OrderBy(a => a.Count).ToList();

        It Should_Partition_Each_Element = () =>
        {
            answer.Count.ShouldEqual(expect.Count);
            for(var i=0; i<expect.Count; i++)
            {
                answer[i].Count.ShouldEqual(expect[i].Count);
                for (var j = 0; j < expect[i].Count; j++)
                {
                    answer[i].Where(a => a == expect[i][j]).ToList().Count.ShouldEqual(expect[i].Where(a => a == expect[i][j]).ToList().Count);
                }
            }
        };

        private static Dictionary<long, List<List<long>>> set;
        private static long input;
        private static List<List<long>> parts;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Updating_Partition_Set_For_4
    {
        Establish context = () =>
        {
            set = new Dictionary<long, List<List<long>>>
            {
                {
                    2, new List<List<long>>
                    {
                        new List<long> { 2 },
                        new List<long> { 1,1 },
                    }
                },
                {
                    3, new List<List<long>>
                    {
                        new List<long>{ 3 },
                        new List<long>{ 2,1 },
                        new List<long>{ 1,1,1 }
                    }
                }
            };
            input = 4;
            parts = new List<List<long>> 
            {
                new List<long>{ 3,1 },
                new List<long>{ 2,2 }
            };
            expect = new List<List<long>>
            {
                new List<long> { 4 },
                new List<long> { 3,1 },
                new List<long> { 2,2 },
                new List<long> { 2,1,1 },
                new List<long> { 1,1,1,1 }
            };
        };

        Because of = () => answer = IntPart.UpdatePartitionSet(set, input, parts).OrderBy(a => a.Count).ToList();

        It Should_Partition_Each_Element = () =>
        {
            answer.Count.ShouldEqual(expect.Count);
            for (var i = 0; i < expect.Count; i++)
            {
                answer[i].Count.ShouldEqual(expect[i].Count);
                for (var j = 0; j < expect[i].Count; j++)
                {
                    answer[i].Where(a => a == expect[i][j]).ToList().Count.ShouldEqual(expect[i].Where(a => a == expect[i][j]).ToList().Count);
                }
            }
        };

        private static Dictionary<long, List<List<long>>> set;
        private static long input;
        private static new List<List<long>> parts;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Updating_Partition_Set_For_5
    {
        Establish context = () =>
        {
            set = new Dictionary<long, List<List<long>>>
            {
                {
                    2, new List<List<long>>
                    {
                        new List<long> { 2 },
                        new List<long> { 1,1 },
                    }
                },
                {
                    3, new List<List<long>>
                    {
                        new List<long>{ 3 },
                        new List<long>{ 2,1 },
                        new List<long>{ 1,1,1 }
                    }
                },
                {
                    4, new List<List<long>>
                    {
                        new List<long>{ 4 },
                        new List<long>{ 3,1 },
                        new List<long>{ 2,2 },
                        new List<long>{ 2,1,1 },
                        new List<long>{ 1,1,1,1 }
                    }
                }
            };
            input = 5;
            parts = new List<List<long>>
            {
                new List<long>{ 4,1 },
                new List<long>{ 3,2 }
            };
            expect = new List<List<long>>
            {
                new List<long>{ 5 },
                new List<long>{ 4,1 },
                new List<long>{ 3,1,1 },
                new List<long>{ 2,2,1 },
                new List<long>{ 2,1,1,1 },
                new List<long>{ 1,1,1,1,1 },
                new List<long>{ 3,2 },
                //new List<int>{ 2,2,1 },
                //new List<int>{ 2,1,1,1 },
            };
        };

        Because of = () => answer = IntPart.UpdatePartitionSet(set, input, parts);

        It Should_Partition_Each_Element = () =>
        {
            answer.Count.ShouldEqual(expect.Count);
            for (var i = 0; i < expect.Count; i++)
            {
                answer[i].Count.ShouldEqual(expect[i].Count);
                for (var j = 0; j < expect[i].Count; j++)
                {
                    answer[i].Where(a => a == expect[i][j]).ToList().Count.ShouldEqual(expect[i].Where(a => a == expect[i][j]).ToList().Count);
                }
            }
        };

        private static Dictionary<long, List<List<long>>> set;
        private static long input;
        private static new List<List<long>> parts;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Updating_Partition_Set_For_6
    {
        Establish context = () =>
        {
            set = new Dictionary<long, List<List<long>>>
            {
                {
                    2, new List<List<long>>
                    {
                        new List<long> { 2 },
                        new List<long> { 1,1 },
                    }
                },
                {
                    3, new List<List<long>>
                    {
                        new List<long>{ 3 },
                        new List<long>{ 2,1 },
                        new List<long>{ 1,1,1 }
                    }
                },
                {
                    4, new List<List<long>>
                    {
                        new List<long>{ 4 },
                        new List<long>{ 3,1 },
                        new List<long>{ 2,2 },
                        new List<long>{ 2,1,1 },
                        new List<long>{ 1,1,1,1 }
                    }
                },
                {
                    5, new List<List<long>>
                    {
                        new List<long>{ 5 },
                        new List<long>{ 4,1 },
                        new List<long>{ 3,2 },
                        new List<long>{ 3,1,1 },
                        new List<long>{ 2,1,1,1 },
                        new List<long>{ 1,1,1,1,1 }
                    }
                }
            };
            input = 6;
            parts = new List<List<long>>
            {
                new List<long>{ 5,1 },
                new List<long>{ 4,2 },
                new List<long>{ 3,3 },
            };
            expect = new List<List<long>>
            {
                new List<long>{ 6 },
                new List<long>{ 5,1 },
                new List<long>{ 4,1,1},
                new List<long>{ 3,2,1 },
                new List<long>{ 3,1,1,1 },
                new List<long>{ 2,1,1,1,1 },
                new List<long>{ 1,1,1,1,1,1 },
                new List<long>{ 4,2 },
                new List<long>{ 2,2,2 },
                new List<long>{ 2,2,1,1 },
                new List<long>{ 3,3 },
            };
        };

        Because of = () => answer = IntPart.UpdatePartitionSet(set, input, parts);

        It Should_Partition_Each_Element = () =>
        {
            answer.Count.ShouldEqual(expect.Count);
            for (var i = 0; i < expect.Count; i++)
            {
                answer[i].Count.ShouldEqual(expect[i].Count);
                for (var j = 0; j < expect[i].Count; j++)
                {
                    answer[i].Where(a => a == expect[i][j]).ToList().Count.ShouldEqual(expect[i].Where(a => a == expect[i][j]).ToList().Count);
                }
            }
        };

        private static Dictionary<long, List<List<long>>> set;
        private static long input;
        private static new List<List<long>> parts;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Removing_Duplicates_From_Partition_Sets
    {
        Establish context = () =>
        {
            input = new List<List<long>>
            {
                new List<long>{ 5 },
                new List<long>{ 4,1 },
                new List<long>{ 3,1,1 },
                new List<long>{ 2,2,1 },
                new List<long>{ 2,1,1,1 },
                new List<long>{ 1,1,1,1,1 },
                new List<long>{ 3,2 },
                new List<long>{ 2,2,1 },
                new List<long>{ 2,1,1,1 },
            };
            expect = new List<List<long>>
            {
                new List<long>{ 5 },
                new List<long>{ 4,1 },
                new List<long>{ 3,1,1 },
                new List<long>{ 2,2,1 },
                new List<long>{ 2,1,1,1 },
                new List<long>{ 1,1,1,1,1 },
                new List<long>{ 3,2 },
            };
        };

        Because of = () => answer = IntPart.RemoveDuplicates(input);

        It Should_Return_The_List_With_No_Duplicates = () =>
        {
            for (var i = 0; i < answer.Count; i++)
            {
                for (var j = 0; j < answer[i].Count; j++)
                {
                    if (answer[i][j] != expect[i][j])
                    {
                        var ans = answer[i][j];
                        var exp = expect[i][j];
                    }
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        private static List<List<long>> input;
        private static List<List<long>> expect;
        private static List<List<long>> answer;
    }

    public class When_Finding_The_Product_Of_A_Partition
    {
        Establish context = () =>
        {
            input = new List<List<long>>
            {
                new List<long>{ 2,2,2,1 },
                new List<long>{ 3,3,2,1,1 }
            };
            expect = new List<long> { 8, 18 };
            answer = new List<long>();
        };

        readonly Because of = () =>
        {
            for (var i = 0; i < input.Count; i++)
            {
                answer.Add(IntPart.FindProduct(input[i]));
            }
        };

        It Should_Return_The_Correct_Integer = () =>
        {
            for (var i = 0; i < answer.Count; i++)
            {
                answer[i].ShouldEqual(expect[i]);
            }
        };

        private static List<List<long>> input;
        private static List<long> expect;
        private static List<long> answer;
    }

    public class When_Finding_Range_Mean_And_Median
    {
        Establish context = () =>
        {
            input = new List<List<long>> {
                new List<long>{ 1, 2, 3, 4, 5, 6, 6, 7, 7, 7, 8, 9, 9, 9, 9, 10, 11 } ,
                new List<long>{ 1,2,3,4,5 },
                new List<long>{ 1,2,3,4 },
                new List<long>{ 1,3,5,7 },
                new List<long>{ 1,2,3,4,6,10 }
            };
            expect = new List<string>
            {
                "Range: 10 Average: 6.65 Median: 7.00",
                "Range: 4 Average: 3.00 Median: 3.00",
                "Range: 3 Average: 2.50 Median: 2.50",
                "Range: 6 Average: 4.00 Median: 4.00",
                "Range: 9 Average: 4.33 Median: 3.50"
            };
            answer = new List<string>();
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Count; i++)
            {
                answer.Add(IntPart.GetStats(input[i]));
            }
        };

        It Should_Return_Range_Mean_And_Median = () =>
        {
            for (var i = 0; i < answer.Count; i++)
            {
                if (answer[i] != expect[i])
                {
                    var ans = answer[i];
                    var exp = expect[i];
                }
                answer[i].ShouldEqual(expect[i]);
            }
        };

        private static List<List<long>> input;
        private static List<string> expect;
        private static List<string> answer;
    }

    public class When_Calling_Part
    {
        Establish context = () =>
        {
            inputs = new List<long>
            {
                1,2,3,4
            };
            expects = new List<string>
            {
                "Range: 0 Average: 1.00 Median: 1.00",
                "Range: 1 Average: 1.50 Median: 1.50",
                "Range: 2 Average: 2.00 Median: 2.00",
                "Range: 3 Average: 2.80 Median: 3.00",
            };
            answer = new List<string>();
        };

        Because of = () =>
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                answer.Add(IntPart.Part(inputs[i]));
            }
        };

        It Should_Return_Correct_Stats = () =>
        {
            for (var i = 0; i < answer.Count; i++)
            {
                if (answer[i] != expects[i])
                {
                    var ans = answer[i];
                    var exp = expects[i];
                }
                answer[i].ShouldEqual(expects[i]);
            }
        };

        private static List<long> inputs;
        private static List<string> expects;
        private static List<string> answer;
    }
}