using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disceret_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimumnumber, maximumnumber;
            Console.WriteLine("please inter minimum number :");

            minimumnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("please inter maximum number :");

            maximumnumber = int.Parse(Console.ReadLine());

            int num, sum, number;
            for (num = minimumnumber; num < +maximumnumber; num++)
            {
                sum = 0;
                for (number = 1; number < num; number++)
                {
                    if (num % number == 0)
                        sum = sum + number;
                }
                if (sum == num && num != 0)
                    Console.WriteLine("prefect number "+num);
            }
        }
    }
}
