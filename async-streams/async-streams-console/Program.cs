using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace async_streams_console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: Start");

            await foreach (var item in FetchItems())
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: {item}");
            }

            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: End");
        }

        static async IAsyncEnumerable<int> FetchItems()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}
