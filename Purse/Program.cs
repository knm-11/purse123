using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debet;
using Credit;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 d = new Class1();
            Console.WriteLine(d.debet);
            Class1 c = new Class1();
            Console.WriteLine(c.czrt);        }
    }
}
