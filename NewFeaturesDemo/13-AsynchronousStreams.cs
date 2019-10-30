using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFeaturesDemo
{
    // since 8.0
    public class AsynchronousStreams
    {
        public async Task IterateAsync()
        {
            await foreach (var number in GetAllNumbersAsync())
            {
                Console.WriteLine($"number: {number}");
            }
        }

        public async IAsyncEnumerable<string> GetAllNumbersAsync()
        {
            var pages = await GetPageCountAsync();

            for (var i = 0; i < pages; i++)
            {
                var numbers = await GetNumbersAsync(i);

                foreach (var number in numbers)
                {
                    var str = await GetNumberAsStringAsync(number);

                    yield return str;
                }
            }
        }

        public async Task<int> GetPageCountAsync()
        {
            await Task.Delay(100);

            return 10;
        }

        public async Task<IEnumerable<int>> GetNumbersAsync(int page)
        {
            await Task.Delay(100);

            return Enumerable.Range(page * 10, 10);
        }

        public async Task<string> GetNumberAsStringAsync(int number)
        {
            await Task.Delay(100);

            return number.ToString();
        }
    }
}
