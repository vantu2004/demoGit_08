using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGit_08
{
    internal class Program
    {
        private string name;
        private string id;
        private void info()
        {
            name = Console.ReadLine();
            id = Console.ReadLine();
            Console.WriteLine(name + " " + id);
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.info();
        }
    }
}
