using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number >= 50)
            {
                Console.WriteLine($"입력하신숫자 {number}는(은)50이상의 수 입니다.");
            }
            else
            {
                Console.WriteLine($"입력하신 {number}는(은)50 미만의 수 입니다");
            }
            
                    

        }
    }
}
