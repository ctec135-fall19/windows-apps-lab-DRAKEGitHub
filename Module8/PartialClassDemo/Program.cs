using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a myClass object and call the method
            // prints with value passed to constructor
            MyClass mc = new MyClass(123);
            mc.printState();
        }
    }
}
