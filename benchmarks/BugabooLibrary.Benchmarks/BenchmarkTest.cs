using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

namespace BugabooLibrary.Benchmarks
{
    [NativeMemoryProfiler]
    [MemoryDiagnoser]
    public class BenchmarkTest
    {
        [Benchmark]
        public void ClassicMultiply()
        {
            var i = 4 * 10;
            Console.WriteLine(i);
        }

        [Benchmark]
        public void ShiftLike()
        {
            var i = 10 >> 2;
            Console.WriteLine(i);
        }
    }
}
