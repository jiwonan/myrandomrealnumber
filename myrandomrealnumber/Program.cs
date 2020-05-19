using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num;
            num = rand.Next(0, 200);

            int answer = -1;

            Console.WriteLine(num);

            while (answer != num)
            {
                Console.Write("숫자를 입력해주세요: ");
                answer = int.Parse(Console.ReadLine());
                if (num > answer)
                    Console.WriteLine(answer + "보다는 큰 숫자입니다.\n");
                else if (num < answer)
                    Console.WriteLine(answer + "보다는 작은 숫자입니다.\n");
            }

            Console.WriteLine("정답입니다!");


        }
    }
}
