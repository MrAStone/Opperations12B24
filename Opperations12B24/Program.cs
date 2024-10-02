namespace Opperations12B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opperations
            // Arithmetic
            int num1, num2, num3;
            double dNum1, dNum2, dNum3;
            num1 = 12;
            num2 = 15;
            dNum1 = 2.9;
            dNum2 = 6.45;
            //• addition
            num3 = num1 + num2;
            dNum3 = dNum1 + dNum2;
            // num3 = dNum1 + num2; can't add double and store in int
            dNum3 = num1 + num2;


            //• subtraction
            num3 = num2 - num1;
            dNum3 = dNum2 - dNum1;

            //• multiplication
            num3 = num1 * num2;
            dNum3 = dNum1 * dNum2;

            num1 = 7;
            num2 = 3;
            dNum1 = 7;
            dNum2 = 3;
            //• real / float division
            dNum3 = num1 / num2;
            Console.WriteLine(dNum3);
            dNum3 = dNum1 / dNum2;
            Console.WriteLine(dNum3);
            dNum3 = num1 / dNum2;
            Console.WriteLine(dNum3);
            dNum3 = dNum1 / num2;
            Console.WriteLine(dNum3);
            //• integer division, including remainders
            num3 = num1 % num2; // finds remainder (MOD)
            Console.WriteLine(11 / 2);
            Console.WriteLine(11 / 2.0);
            Console.WriteLine(11 % 2);
            Console.WriteLine(Convert.ToInt32(13 / 2.0));

            //• exponentiation
            Console.WriteLine(Math.Pow(2, 8));
            dNum3 = Math.Pow(num1, num2);
            dNum3 = Math.Sqrt(9);

            //• rounding
            Console.WriteLine(Math.Round(1.234));
            Console.WriteLine(Math.Round(1.235, 2));
            Console.WriteLine(Math.Ceiling(1.234));
            Console.WriteLine(Math.Ceiling(-1.234));
            Console.WriteLine(Math.Floor(1.989));
            Console.WriteLine(Math.Floor(-1.989));

            //• truncation
            Console.WriteLine(Math.Truncate(3.12345678));
            Console.WriteLine(Math.Truncate(-3.12345678));

            // Relational operations
            int a = 3;
            // equal to
            if (a == 3)
            {
                Console.WriteLine("It is 3");
            }
            // not equal to
            if (a != 3)
            {
                Console.WriteLine("It is not 3");
            }
            // less than
            if (a < 3)
            {
                Console.WriteLine("Less than 3");
            }
            // greater than
            if (a > 3)
            {
                Console.WriteLine("Greater than 3");
            }

            // less than or equal to
            if (a <= 3)
            {
                Console.WriteLine("Less than or equal to 3");
            }

            // greater than or equal to
            if (a >= 3)
            {
                Console.WriteLine("Greater than or equal to 3");
            }

            // Boolean operations
            bool first, second;
            first = true;
            second = true;
            Console.WriteLine(first);
            //  NOT
            Console.WriteLine(!first);//false
            Console.WriteLine(!!first);//true
            //• AND - Only true if all inputs are true
            Console.WriteLine(first && second );//true
            Console.WriteLine(first && !second); // false
            Console.WriteLine(!first&&!second);// false
            //• OR - Only true if at least one input is true
            Console.WriteLine(first||second);//true
            Console.WriteLine(first||!second);//true
            Console.WriteLine(!first||second);//true
            Console.WriteLine(!first||!second);//false
            //• XOR. - Only true if one but not both are true
            Console.WriteLine(first^second);//false
            Console.WriteLine(!first^second);//true
            Console.WriteLine(first^!second);//true
            Console.WriteLine(!first^!second);//false

            // Mistakes that are made!
            int b = 5;
            int c = 7;
            //if (c > a && b) - b is not Boolean
            if(c>a && c > b)
            {
                Console.WriteLine("c is greater than a and b");
            }

            if(a<1 && a > 10)
            {
                Console.WriteLine("This will never work");
            }
            if(a<1 || a > 10)
            {
                Console.WriteLine("This is better");
            }
            Console.WriteLine(!(first && second));//False first && second = true this is then !




        }
    }
}
