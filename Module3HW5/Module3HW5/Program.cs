using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Module3HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Результат: " + SumString().Result);

            Console.ReadKey();
        }

        private static async Task<string> SumString()
        {
            string file1 = await Task.Run(() => ReadFile1Async());
            string file2 = await Task.Run(() => ReadFile2Async());

            return $"{file1} {file2}";
        }

        private static async Task<string> ReadFile1Async()
        {
            string result = string.Empty;

            using (StreamReader reader = new StreamReader("file1.txt"))
            {
                result = await reader.ReadToEndAsync();
            }

            return result;
        }

        private static async Task<string> ReadFile2Async()
        {
            string result = string.Empty;

            using (StreamReader reader = new StreamReader("file2.txt"))
            {
                result = await reader.ReadToEndAsync();
            }

            return result;
        }
    }
}
