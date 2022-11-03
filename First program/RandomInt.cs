using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    class RandomInt
    {
        public void randint()
        {
            Random random = new Random();
            int num = random.Next(100);
            Console.WriteLine(num);
            Console.ReadLine();
                }
    }
}
