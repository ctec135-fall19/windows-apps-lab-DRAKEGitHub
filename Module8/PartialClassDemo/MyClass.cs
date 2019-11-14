using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class MyClass
    {
        // create a constructor
        public MyClass(int x)
        {
            this.myField = x;
        }

        // create file to print
        public void printState()
        {
            Console.WriteLine("state: {0}", myField);
        }
    }
}
