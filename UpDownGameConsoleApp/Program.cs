using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownGameConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdNum = new Random();
            int resultNum = rdNum.Next(60);
            Console.WriteLine("0~60까지의 값을 입력하여, 알아맞추세요!");

            while(true)
            {
                int inputValue = int.Parse(Console.ReadLine());
                if(resultNum == inputValue)
                {
                    Console.WriteLine("정답" + resultNum + "을 맞추었음!");
                    break;
                }
                else if(resultNum > inputValue)
                {
                    Console.WriteLine("Up!" + inputValue + " 보다 높은 값을 입력!");
                }
                else
                {
                    Console.WriteLine("Down!" + inputValue + " 보다 낮은 값을 입력!");
                }
            }
            Console.ReadLine();
        }
    }
}
