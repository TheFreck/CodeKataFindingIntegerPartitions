using CodeKataGettingAlongWithIntegerPartitions;

var again = true;
var getPartitions = true;
do
{
    Console.WriteLine("Would you like to partition [p] an integer or get the stats [s]?");
    var input = Console.ReadLine();
    if(input.ToLowerInvariant() == "p")
    {
        getPartitions = true;
        again = false;
        break;
    }
    else if(input.ToLowerInvariant() == "s")
    {
        getPartitions= false;
        again = false;
        break;
    }
    else
    {
        Console.WriteLine("Enter either 's' or 'p'");
        again = true;
        continue;
    }
} while (again);

if(getPartitions)
{
    var keepGoing = true;
    do
    {
        Console.WriteLine("What integer would you like to partition?");
        var num = Console.ReadLine();
        var partitions = new Dictionary<long,List<List<long>>>();
        if(int.TryParse(num, out var integer))
        {
            partitions = IntPart.Partition(integer);
        }
        else
        {
            Console.WriteLine("That was not an integer. Try again.");
        }
        if(partitions?.Count > 0)
        {
            for(var i=1; i<=partitions.Count; i++)
            {
                Console.WriteLine(i+":");
                for(var j=0; j < partitions[i].Count; j++)
                {
                    for(var k=0; k < partitions[i][j].Count; k++)
                    {
                        Console.Write(partitions[i][j][k] + ",");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    } while (keepGoing);
}
else
{
    var keepGoing = true;
    do
    {
        Console.WriteLine("What integer would you like to get partitioning stats for?");

        var num = Console.ReadLine();
        var partitionStats = string.Empty;
        if (int.TryParse(num, out var integer))
        {
            Console.WriteLine(IntPart.Part(integer));
        }
        else
        {
            Console.WriteLine("That was not an integer. Try again.");
        }
    } while (true);
}