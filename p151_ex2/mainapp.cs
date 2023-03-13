using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class mainapp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number >= 90)
            {
                Console.WriteLine($"입력하신점수 {number}는(은)A학점입니다.");
            }
            else if (number >= 80)
            {
                Console.WriteLine($"입력하신점수 {number}는(은)B학점입니다.");
            }
            else if (number >= 70)
            {
                Console.WriteLine($"입력하신점수 {number}는(은)C학점입니다.");
            }
            else if (number <= 69)
            {
                Console.WriteLine($"입력하신점수 {number}는(은)f학점입니다.");

            }
        }
    }
}
