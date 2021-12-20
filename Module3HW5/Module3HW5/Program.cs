using System;
using System.IO;
using System.Threading.Tasks;

namespace Module3HW5
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static async Task<string> ReadFile1Async()
        {
            string result = string.Empty;

            using (StreamReader reader = new StreamReader("file1.txt"))
            {
                result = await reader.ReadToEndAsync();
            }

            return result;
        }

        static async Task<string> ReadFile2Async()
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
