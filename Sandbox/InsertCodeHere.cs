using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Case 1
            Console.WriteLine("Start of Case 1");
            int c1 = 1;
            while (c1 < 20)
            {
                Console.WriteLine(c1); // Uncomment to see result: 3 5 7 9 11 13 15 17 19
                c1 = c1 + 2;
            }
            Console.WriteLine("End of Case 1");


            // Case 2
            Console.WriteLine("Start of Case 2");
            int c2 = 1;
            while (c2 < 20)
            {
                Console.WriteLine(c2); // Uncomment to see result: 1 2 4 8 16
                c2 = c2 * 2;
            }
            Console.WriteLine("End of Case 2");


            // Case 3
            Console.WriteLine("Start of Case 3");
            int c3 = 15;
            while ((c3 < 20) && (c3 > 10))
            {
                Console.WriteLine(c3);  // Uncomment to see result: 15 16 17 18 19
                c3++;
            }
            Console.WriteLine("End of Case 3");


            // Case 4
            Console.WriteLine("Start of Case 4");
            int c4 = 10;
            while (c4 >= 0)
            {
                Console.WriteLine(c4);  // Uncomment to see result: 10 9 8 7 6 5 4 3 2 1 0
                c4--;
            }
            Console.WriteLine("End of Case 4");


            // Insert code for the below four cases

            // Case 5
            // Print out the numbers 3,5,7,9
            Console.WriteLine("Start of Case 5");
            int c5 = 3;
            while ((c5 < 10) && (c5 > 2))
            {
                Console.WriteLine(c5);
                c5 = c5 + 2;
            }
            Console.WriteLine("End of Case 5");


            // Case 6
            // Print out the numbers 0,1,3,7,15,31
            Console.WriteLine("Start of Case 6");
            int c6 = 0;
            while (c6 >= 0 && c6 <= 31)
            {
                Console.WriteLine(c6);
                c6 = 1 + c6 * 2;
            }
            Console.WriteLine("End of Case 6");

            // Case 7
            // Print out the numbers 100,50,25,12,6,3,1


            // Case 8 (DIFFICULT)
            // Print out the numbers 10,9,12,7,14,5,16,3,18,1



            // The LAST line of code should be ABOVE this line
        }
    }
}
