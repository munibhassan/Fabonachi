using FirstProgram;
using System;
public class RandomStringInArraySample
{
    public string checkstring()
    {
        string[] authors = { "S", "O" };
        Random rand = new Random();

        int index = rand.Next(authors.Length);
        // Display the result.  
        //  Console.WriteLine(authors[index]);

        return authors[index];

    }
    public void method()
    {
        string[,] roomString = new string[4, 4];
        int count = 0;
        string rep = "";
        string[,] horiz = new string[4, 4];
        string[,] verticle = new string[4, 4];
        string[,] munnaarray = new string[8, 8];
        Console.WriteLine("Random  sequence is  ");
        int Eight_Row = 0;
        int Eight_Col = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                roomString[i, j] = checkstring();
                Console.Write(roomString[i, j] + " ");

                //horiz[i,j] = roomString[i, j];
                if ((i < 4) && (j < 4))
                {
                    munnaarray[Eight_Row, Eight_Col] = roomString[i, j];
                    Console.Write(munnaarray[Eight_Row, Eight_Col] + " ");
                    Eight_Col++;
                    if (Eight_Col == 8)
                    {
                        Eight_Col = 0;
                    }
                }

            }
            Eight_Row++;
            if (Eight_Row == 8)
            {
                Eight_Row = 0;
            }
            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("Verticle sequence is  ");
        // horiz=verticle;
        // Array.Resize(ref munnaarray,);
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {


                verticle[i, j] = horiz[j, i];

                Console.Write(verticle[i, j] + " ");




            }

            Console.WriteLine();

        }


        Console.WriteLine("Verticle sequence is  ");

        Console.WriteLine();
        //  count = Matchstring(verticle, count);
        Console.WriteLine("Total count of SOS : " + count);
        Console.WriteLine();

        Console.WriteLine("Horizental sequence is  ");

        Console.WriteLine();
        // horiz = "";
        // verticle = "";
    }
    public int Matchstring(string check, int count = 0)
    {
        string match = "SOS";


        if (check.Contains(match))
        {

            count++;

            Console.WriteLine(" SOS  Found " + count);



        }
        else
        { Console.WriteLine(" SOS not Found"); }
        return count;

    }

    public static void Main()
    {
        RandomStringInArraySample p = new RandomStringInArraySample();
        // p.checkstring();
        p.method();

    }
}