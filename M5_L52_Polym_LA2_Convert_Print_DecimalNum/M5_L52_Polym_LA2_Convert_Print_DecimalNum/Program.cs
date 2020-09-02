using System;

namespace M5_L52_Polym_LA2_Convert_Print_DecimalNum
{
    class BaseConversion
    {
        private int Binary(int number)
        {
            //toDo
            int i, j, binno = 0;

            i = 1;

            for (j = number; j > 0; j = j / 2)
            {
                binno = binno + (number % 2) * i;
                i = i * 10;
                number = number / 2;
            }
            return binno;
        }
        private int Octal(int number)
        {
            //ToDo
            int octalNumber = 0, i = 1;

            while (number != 0)
            {
                octalNumber += (number % 8) * i;
                number /= 8;
                i *= 10;
            }

            return octalNumber;
        }
        private string PrintHexDigit(int number)
        {
            //ToDo
            string hexStr = null;
            int n = number;
            int r;
            do
            {
                r = n % 16;
                if (r > 9)
                {
                    hexStr += (char)('A' + (r - 10));
                    /*if (r == 10) hexStr += 'A';
                    else if (r == 11) hexStr += 'B';
                    else if (r == 12) hexStr += 'C';
                    else if (r == 13) hexStr += 'D';
                    else if (r == 14) hexStr += 'E';
                    else hexStr += 'F';
                    */
                }
                else
                { 
                    hexStr += r;   
                }
                n /= 16;
            } while (n > 0);
            char[] hCA = hexStr.ToCharArray();
            Array.Reverse(hCA);
            hexStr = new string(hCA);
            return hexStr;
        }
        public void Print(int value, int nbase = 10)
        {
            //ToDo
            if (nbase == 10)
            {
                Console.WriteLine("Decinal value: {0}", value);
            }
            else if (nbase == 2)
            {
                Console.WriteLine("Decimal value {0} in Binary is: {1}",value, Binary(value));
            }
            else if (nbase == 8)
            {
                Console.WriteLine("Decimal value {0} in Octal is: {1}", value, Octal(value));
            }
            else if (nbase == 16)
            {
                Console.WriteLine("Decimal value {0} in Hexa-Decimal is: {1}", value, PrintHexDigit(value));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var num = new BaseConversion();
            int val, nbase;
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                Console.WriteLine("Example: ");
                Console.WriteLine("To print Decimal 4 in Binary: print 4 2");
                Console.WriteLine("To print Decimal 9 in Octal: print 9 8");
                Console.WriteLine("To print Decimal 11 in Decimal: print 11");
                Console.WriteLine("To print Decimal 11 in Hexa-Decimal: print 11 16");
                Console.WriteLine("To exit from the program: exit");

                command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs.Length == 0)
                    continue;
                else if (cmdArgs[0] == "exit") return;
                else if (cmdArgs.Length == 2)
                {
                    if (cmdArgs[0] == "print")
                    {
                        val = int.Parse(cmdArgs[1]);
                        num.Print(val);
                    }
                    else continue;
                }
                else if (cmdArgs.Length == 3)
                {
                    if (cmdArgs[0] == "print")
                    {
                        val = int.Parse(cmdArgs[1]);
                        nbase = int.Parse(cmdArgs[2]);
                        num.Print(val, nbase);
                    }
                    else continue;
                }
                else
                {
                    Console.WriteLine("\nUnknown Command!. Please enter command in proper format.");
                }

                Console.ReadKey();
            }
        }
    }
}
