using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace FileInputOutputOperations
{
    internal class AsynchronousStreamDemo
    {
        public static IEnumerable<int> GetNumbers(int start, int end)
        {
            Random random = new Random();  
            var returnList = new List<int>();

            for (int i = start; i < end; i++)
            {
                int number = random.Next(500, 1000);
                Console.Write(i + " ");
                returnList.Add(i);
                Thread.Sleep(number);
                
            }
            return returnList;
        }
        public static async IAsyncEnumerable<int> GetNumbersAsync(int start, int end)
        {
            var random = new Random();
            for (int i = start; i < end; i++)
            {
                yield return i;            // produces the value
                await Task.Delay(400);     // async wait between yields
            }
        }

    }
}
