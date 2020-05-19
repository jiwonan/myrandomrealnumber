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
            double num;
            num = rand.NextDouble();

            int pc_answer = (int)(Math.Round(num, 3) * 100);

            int answer = -1;

            Console.WriteLine(pc_answer);
            
            while (answer != pc_answer)
            {
                Console.Write("숫자를 입력해주세요: ");
                answer = int.Parse(Console.ReadLine());
                if (pc_answer > answer)
                    Console.WriteLine(answer + "보다는 큰 숫자입니다.\n");
                else if (pc_answer < answer)
                    Console.WriteLine(answer + "보다는 작은 숫자입니다.\n");
            }

            Console.WriteLine("정답입니다!");


        }
    }
}
