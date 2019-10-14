using System;

namespace ConsoleApp9
{
    static class Program
    {
        static void Print(bool[] arr, bool[] vs, string[] arr1)
        {
            int i = arr.Length;
            int cnt2 = 0;
            int tmp = 0;
            for (int j = 0; j < 4; j++)
                if (vs[j] == false)
                {
                    Console.Write($"{arr1[j],5} | ");
                    tmp++;
                }
            Console.WriteLine("    f" + " |");
            for (int o = 0; o < tmp * 8 + 7; o++)
                Console.Write("-");
            Console.WriteLine();
            if (i == 2)
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine($"{a,5} | {arr[cnt2],5} |");
                    cnt2++;
                }
            else if (i == 4)
                for (int a = 0; a < 2; a++)
                    for (int b = 0; b < 2; b++)
                    {
                        Console.WriteLine($"{a,5} | {b,5} | {arr[cnt2],5} |");
                        cnt2++;
                    }
            else if (i == 8)
                for (int a = 0; a < 2; a++)
                    for (int b = 0; b < 2; b++)
                        for (int c = 0; c < 2; c++)
                        {
                            Console.WriteLine($"{a,5} | {b,5} | {c,5} | {arr[cnt2],5} |");
                            cnt2++;
                        }
            else if (i == 16)
                for (int a = 0; a < 2; a++)
                    for (int b = 0; b < 2; b++)
                        for (int c = 0; c < 2; c++)
                            for (int d = 0; d < 2; d++)
                            {
                                Console.WriteLine($"{a,5} | {b,5} | {c,5} | {d,5} | {arr[cnt2],5} |");
                                cnt2++;
                            }
        }

        static bool[] Check(bool[] vs, string[] arr1)
        {
            for (int i = 0; i < 3; i++)
                for (int j = i + 1; j < 4; j++)
                    if (arr1[i] == arr1[j])
                        vs[j] = true;
            return vs;
        }

        static void Main(string[] args)
        {

            bool x, y, z, w;
            int cnt = 0, cnt1 = 0, n;
            bool f;
            bool[] vs = new bool[4];

            string str = Console.ReadLine();
            string[] arr1 = new string[4];
            arr1 = str.Split(" ");

            Check(vs, arr1);

            for (int t = 0; t < vs.Length; t++)
                if (vs[t] == true)
                    cnt1++;

            if (cnt1 == 1)
            {
                 n = 8;
                 bool[] arr = new bool[n];
                    if (vs[0] == true)
                    {
                    for (int a = 0; a < 2; a++)
                        for (int b = 0; b < 2; b++)
                            for (int c = 0; c < 2; c++)
                            {
                                if (a == 0) { y = false; }
                                else { y = true; }
                                if (b == 0) { z = false; }
                                else { z = true; }
                                if (c == 0) { w = false; }
                                else { w = true; }
                                f = (y & !w) | (y & w & !z);
                                arr[cnt] = f;
                                cnt++;
                            }
                    }
                    else if (vs[1] == true)
                    {
                    for (int a = 0; a < 2; a++)
                        for (int b = 0; b < 2; b++)
                            for (int c = 0; c < 2; c++)
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { z = false; }
                                else { z = true; }
                                if (c == 0) { w = false; }
                                else { w = true; }
                                f = (x & !w) | (x & w & !z);
                                arr[cnt] = f;
                                cnt++;
                            }
                    }
                    else if (vs[2] == true)
                    {
                    for (int a = 0; a < 2; a++)
                        for (int b = 0; b < 2; b++)
                            for (int c = 0; c < 2; c++)
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { y = false; }
                                else { y = true; }
                                if (c == 0) { w = false; }
                                else { w = true; }
                                f = (x & !w) | (y & w & !x);
                                arr[cnt] = f;
                                cnt++;
                            }
                    }
                    else if (vs[3] == true)
                    {
                    for (int a = 0; a < 2; a++)
                        for (int b = 0; b < 2; b++)
                            for (int c = 0; c < 2; c++)
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { y = false; }
                                else { y = true; }
                                if (c == 0) { z = false; }
                                else { z = true; }
                                f = false | (y & x & !z);
                                arr[cnt] = f;
                                cnt++;
                            }
                    }
                Print(arr, vs, arr1);
            }
            else if (cnt1 == 2)
            {
                n = 4;
                bool[] arr = new bool[n];
                for (int a = 0; a < 2; a++)
                    for (int b = 0; b < 2; b++)
                    {
                        if (vs[0] == true)
                        {
                            if (arr1[1] == arr1[2])
                            {
                                if (a == 0) { y = false; }
                                else { y = true; }
                                if (b == 0) { w = false; }
                                else { w = true; }
                                f = (y ^ !w) || (false & w);
                                arr[cnt] = f;
                                cnt++;
                            }
                            else
                            {
                                if (a == 0) { y = false; }
                                else { y = true; }
                                if (b == 0) { z = false; }
                                else { z = true; }
                                f = false | (y & !z);
                                arr[cnt] = f;
                                cnt++;
                            }
                        }
                        else if (vs[1] == true)
                        {
                            if (arr1[0] == arr1[2])
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { w = false; }
                                else { w = true; }
                                f = false | (x & !w);
                                arr[cnt] = f;
                                cnt++;
                            }
                            else if (arr1[2] == arr1[3])
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { z = false; }
                                else { z = true; }
                                f = false | (x & !z);
                                arr[cnt] = f;
                                cnt++;
                            }
                        }
                        else if (vs[2] == true)
                        {
                            if (arr1[0] == arr1[1])
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { w = false; }
                                else { w = true; }
                                f = false | (x & !w);
                                arr[cnt] = f;
                                cnt++;
                            }
                            else if (arr1[1] == arr1[3])
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { y = false; }
                                else { y = true; }
                                f = false;
                                arr[cnt] = f;
                                cnt++;
                            }
                            else
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { w = false; }
                                else { w = true; }
                                f = (x & !w) | (!x & w);
                                arr[cnt] = f;
                                cnt++;
                            }
                        }
                        else
                        {
                            if (arr1[0] == arr1[1])
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { z = false; }
                                else { z = true; }
                                f = false | (x & !z);
                                arr[cnt] = f;
                                cnt++;
                            }
                            else
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { y = false; }
                                else { y = true; }
                                f = false;
                                arr[cnt] = f;
                                cnt++;
                            }
                        }
                        Print(arr, vs, arr1);
                    }
            }
            else if (cnt1 == 3)
            {
                n = 2;
                bool[] arr = new bool[n];
                for (int a = 0; a < 2; a++)
                    {
                            if (a == 0) { x = false; }
                            else { x = true; }
                            f = false;
                            arr[cnt] = f;
                            cnt++;
                    }
                Print(arr, vs, arr1);
            }
            else
            {
                n = 16;
                bool[] arr = new bool[n];
                for (int a = 0; a < 2; a++)
                    for (int b = 0; b < 2; b++)
                        for (int c = 0; c < 2; c++)
                            for (int d = 0; d < 2; d++)
                            {
                                if (a == 0) { x = false; }
                                else { x = true; }
                                if (b == 0) { y = false; }
                                else { y = true; }
                                if (c == 0) { z = false; }
                                else { z = true; }
                                if (d == 0) { w = false; }
                                else { w = true; }
                                f = (x & !w) | (y & w & !z);
                                arr[cnt] = f;
                                cnt++;
                            }
                Print(arr, vs, arr1);
            }
        }
    }
}
