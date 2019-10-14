using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Print(int cnt, int chck)
        {
            if (cnt == chck) { Console.WriteLine("Tavtologia"); }
            else if (cnt == 0) { Console.WriteLine("Protivorechie"); }
            else { Console.WriteLine("Vipolnimaya"); }
        }

        static void Main(string[] args)
        {
            
            bool x, y, z;
            int cnt = 0, cnt1 = 0, n;
            bool f;

            string str = Console.ReadLine();
            string[] arr1 = new string[3];
            arr1 = str.Split(" ");

            if ((arr1[0] == arr1[1]) || (arr1[0] == arr1[2]) || (arr1[1] == arr1[2]))
            {
                n = 4;
                bool[] arr = new bool[n];
                for (int a = 0; a < 2; a++)
                    for (int b = 0; b < 2; b++)
                    {
                        if (arr1[0] == arr1[1])
                        {
                            if (a == 0) { x = false; }
                            else { x = true; }
                            if (b == 0) { z = false; }
                            else { z = true; }
                            f = !x ^ (!x | z & !x);
                            arr[cnt] = f;
                            cnt++;
                        }
                        else if (arr1[0] == arr1[2])
                        {
                            if (a == 0) { x = false; }
                            else { x = true; }
                            if (b == 0) { y = false; }
                            else { y = true; }
                            f = (!x | !y) ^ (!y | false);
                            arr[cnt] = f;
                            cnt++;
                        }
                        else if (arr1[1] == arr1[2])
                        {
                            if (a == 0) { x = false; }
                            else { x = true; }
                            if (b == 0) { z = false; }
                            else { z = true; }
                            f = (!x | !z) ^ (true & !x);
                            arr[cnt] = f;
                            cnt++;
                        }
                    }
                for (cnt = 0; cnt < arr.Length; cnt++)
                    if (arr[cnt] == true) { cnt1++; }
                Print(cnt1, 4);
            }
            else if ((arr1[0] == arr1[1]) && (arr1[1] == arr1[2]))
            {
                n = 2;
                bool[] arr = new bool[n];
                for (int a = 0; a < 2; a++)
                {
                    if (a == 0) { x = false; }
                    else { x = true; }
                    f = !x ^ (!x | false);
                    arr[cnt] = f;
                    cnt++;
                }
                for (cnt = 0; cnt < arr.Length; cnt++)
                    if (arr[cnt] == true) { cnt1++; }
                Print(cnt1, 2);
            }
            else
            {
                n = 8;
                bool[] arr = new bool[n];
                for (int a = 0; a < 2; a++)
                    for (int b = 0; b < 2; b++)
                        for (int c = 0; c < 2; c++)
                        {
                            if (a == 0) { x = false; }
                            else { x = true; }
                            if (b == 0) { y = false; }
                            else { y = true; }
                            if (c == 0) { z = true; }
                            else { z = false; }
                            f = (!x | !y) ^ (y | z & !x);
                            arr[cnt] = f;
                            cnt++;
                        }

                for (cnt = 0; cnt < arr.Length; cnt++)
                    if (arr[cnt] == true) { cnt1++; }
                Print(cnt1, 8);
            }
        }
    }
}
