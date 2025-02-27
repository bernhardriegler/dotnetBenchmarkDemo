using BenchmarkDotNet.Running;

namespace BenchmarkPlayground
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}
