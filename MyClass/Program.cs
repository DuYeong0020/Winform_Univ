using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class MyClass
    {
        public int MyField1;
        public int myField2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass source = new MyClass();
            source.MyField1 = 10;
            source.myField2 = 20;

            MyClass target = source;
            target.myField2 = 30;

            Console.WriteLine("{0} {1}", source.MyField1, source.myField2);
            Console.WriteLine("{0} {1}", target.MyField1, target.myField2);
        }
    }
}
