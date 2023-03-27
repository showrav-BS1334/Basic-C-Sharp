using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Sharp
{
    internal class Problem12
    {
        private string name;
        public Problem12(string text) {
            name = text;
        }
        public void work(int probNo)
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            Console.WriteLine(name + " is learning c# basic!");
        }
    }
}
