using System;
using System.Collections.Generic;

namespace M4_L43__C_Lists_T_In_class_exe
{
    class Program
    {
        static void Populate(List<int> myList, int size)
        {
            Random obj = new Random();
            for (int i = 0; i < size; i++)
            {
                myList.Add(obj.Next(1, 11));
            }
        }
        static void Display(List<int> myList)
        {

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static bool IsPrime(int val)
        {
            if (val == 1) return false;
            for (int i = 2; i <= val / 2; i++)
            {
                if (val % i == 0) return false;
            }
            return true;
        }
        /*
        static List<int> RemovePrimes(List<int> myList)
        {
            List<int> listWithoutPrime = new List<int>();
            foreach (var item in myList)
            {
                if (!IsPrime(item))
                    listWithoutPrime.Add(item);
            }
            return listWithoutPrime;
        }
        */
        // 1 5 8 9 5 1 7 7 19 7 3
        // 45 22 46 2 7 86 90 7
        // 2 45 22 46 2 7 86 90 7
        static void RorderPrimesAtTheFront(List<int> myList)
        {
            int pos = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if (IsPrime(myList[i]))
                {
                    int x = myList[i];
                    myList.RemoveAt(i);
                    myList.Insert(pos++, x);
                }
            }
        }

        static void RemovePrimes(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (IsPrime(myList[i]))
                {
                    myList.Remove(myList[i]);
                    i--;
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Populate(intList, 20);
            Console.WriteLine("Initial Random Values: ");
            Display(intList);
            //intList=RemovePrimes(intList);
            //RemovePrimes(intList);
            RorderPrimesAtTheFront(intList);
            //Console.WriteLine("List without Prime Values: ");
            Display(intList);



            Console.Read();
        }
    }
}

