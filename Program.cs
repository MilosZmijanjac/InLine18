using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Inline2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Inline18 test = new Inline18();
             test.Run(args[0]);
             test.Output();
        }
        
    }
}
