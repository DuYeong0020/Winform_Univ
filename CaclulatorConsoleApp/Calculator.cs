using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CaclulatorConsoleApp
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Plus(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }

        public static int Plus(string a, string b)
        {
            int result = int.Parse(a) + int.Parse(b);
            return result;
        }
    }
}
