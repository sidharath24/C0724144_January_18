using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0724144
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sum=0;
            for(num=1008;num>=117;num-=81)
            {
                sum += num;
            }
            Console.WriteLine("The sum of the numbers is: {0}",sum);
            Console.ReadLine();
            int i = 1;
            Console.WriteLine(i);
        }
    }
}
