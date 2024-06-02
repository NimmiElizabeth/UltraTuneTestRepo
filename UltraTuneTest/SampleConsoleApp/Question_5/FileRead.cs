using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Question_5
{
    public class FileRead
    {
        /// <summary>
        /// Asynchronous method to read all lines from a text file and return them as a list of strings.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<string>> ReadFile()
        {
            //File placed in bin\Debug\net8.0
            var result = await File.ReadAllLinesAsync(@"Question_5\SampleData.txt");

            return result.Length > 0 ? result.ToList() : new List<string> { };
        }
    }
}
