using BenchmarkDotNet.Attributes;

namespace BenchmarkPlayground;

public class Item
{
    public PropA? propA { get; set; }
    public PropB? propB { get; set; }
}

public class PropA
{
    public string? subPropA { get; set; }
}

public class PropB
{
    public string? subPropB { get; set; }
}

public class Benchmark
{
    private readonly Item? item;

    public Benchmark()
    {
        item = new Item
        {
            propA = new PropA { subPropA = "ValueA" },
            propB = new PropB { subPropB = "ValueB" }
        };
    }

    [Benchmark]
    public string UsingOptionalChaining()
    {
        var subPropA = item?.propA?.subPropA;
        var subPropB = item?.propB?.subPropB;
        return $"{subPropA}, {subPropB}";
    }

    [Benchmark]
    public string CheckingItemNotNullOnce()
    {
        if (item != null)
        {
            var subPropA = item.propA?.subPropA;
            var subPropB = item.propB?.subPropB;
            return $"{subPropA}, {subPropB}";
        }
        return "null, null";
    }
}
