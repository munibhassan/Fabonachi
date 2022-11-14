using System;
using System.Text.RegularExpressions;

namespace FirstProgram
{
    class Program
    {
        public string RandomString()
        {
            string chars = "OS";
            var stringChars = new char[1];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(0, 2)];
            }

            var randomStr = new String(stringChars);
            Console.WriteLine(randomStr);
            return randomStr;

        }
        public void method()
        {
            string check = "SOS";
            string[,] roomString = new string[2, 2];

            string match = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    roomString[i, j] = RandomString();

                    Console.WriteLine(roomString[i, j]);


                    // Console.Write(roomString[i, j] + " ,");
                    // roomString[i, j] = RandomString();


                }
                //     match = RandomString();
                Console.WriteLine();
                //    Console.WriteLine("Nouman check " + match);
                //    if (match.Contains(check))
                //    {
                //        Console.ForegroundColor
                //    = ConsoleColor.Blue;
                //        Console.WriteLine("SOS  Found");
                //    }
                //    else
                //    {
                //        Console.ForegroundColor
                //  = ConsoleColor.Red;
                //        Console.WriteLine("SOS not Found");
                //    }
            }





        }


        //static void Main(string[] args)

        //{
        //    Program p = new Program();
        //// p.RandomString();
        //  p.method();





        //}
    }
}