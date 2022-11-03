using System;
using System.Text.RegularExpressions;

namespace FirstProgram
{
    class Program
    {
        public string RandomString()
        {
            Random ran1 = new Random();
            String val = "";
            string values1 = "SOS";
            
            int length = 1;
            for (int i = 0; i < length; i++)
            {
                int a = ran1.Next(1);
                val = values1 + values1.ElementAt(a);
                Console.WriteLine(val);
            }

            return val;
        }
        public void method()
        {
            string[,] roomString = new string[4, 4];



            string check = "SOS";

            string match = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(roomString[i,j] + " " + RandomString());
                }
                Console.WriteLine();
                for (int k = 0; k < 4; k++)
                {

                    match += roomString[i, 0];
                }
            }
           
            Console.WriteLine("Nouman check " + match);
            if (match.Contains(check))
            {
                Console.WriteLine("SOS  Found");
            }
            else
            {
                Console.WriteLine("SOS not Found");
            }






        }
    

        static void Main(string[] args)

        {
            Program p = new Program();
            p.RandomString();
           // p.method();
           


           

        }
    }
}