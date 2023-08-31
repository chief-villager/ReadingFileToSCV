using BenchmarkDotNet.Running;

namespace fileGetter
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // FileReader fileReader= new FileReader();
            // await fileReader.GetData();

            BenchmarkRunner.Run<FileReader>();
        }
    }
}