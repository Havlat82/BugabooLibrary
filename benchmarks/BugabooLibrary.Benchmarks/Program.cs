using BenchmarkDotNet.Running;

namespace BugabooLibrary.Benchmarks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkTest>();
            Console.ReadKey();
        }
    }
}