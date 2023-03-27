using System;
using System.Collections.Specialized;

namespace Basic_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            solve1(1);

            solve2(2);

            solve3(3);

            solve4(4);

            solve5(5);

            solve6(6);

            solve7(7);

            solve8(8);

            solve9(9);

            solve10(10);

            solve11(11);

            Problem12 obj = new Problem12("Showrav");
            obj.work(12);

            
        }

        static void solve1(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            Console.WriteLine("Hello World!");
        }

        static void solve2(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            int x = 100;
            Console.WriteLine(x);

            long y = 123456789101112;
            Console.WriteLine(y);

            float a = 123.45F;
            Console.WriteLine(a);

            double b = 123.456789;
            Console.WriteLine(b);

            bool flag = false;
            Console.WriteLine(flag);

            char c = 'a';
            //char c = (char)97;
            Console.WriteLine(c);

            string s = "cat";
            Console.WriteLine(s);
        }
        
        static void solve3(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            int a = 1000000000, b = 1000000;
            try
            {
                int x = checked(a * b);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void solve4(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + "  :");
            //string to int and vice verca 
            string a = "12345";
            int i = Convert.ToInt32(a);
            Console.WriteLine(i);

            string A = i.ToString();
            Console.WriteLine(A);

            //string to long and vice verca
            string b = "111222333444555666";
            long l = Convert.ToInt64(b);
            Console.WriteLine(l);

            string B = l.ToString();
            Console.WriteLine(B);

            //string to double and vice verca
            string c = "123.0123456789";
            double d = Convert.ToDouble(c);
            Console.WriteLine(d);

            string C = d.ToString();
            Console.WriteLine(C);

            //string to float and vice verca
            string e = "123.0123456789";
            float f = Convert.ToSingle(e);
            Console.WriteLine(f);

            string E = f.ToString();
            Console.WriteLine(E);

            //string to bool and vice verca
            string G = "true";
            bool H = Convert.ToBoolean(G);
            H = false;
            Console.WriteLine(H);

            string I = Convert.ToString(H);
            Console.WriteLine(I);

            //int to long and vice verca
            int x = 123;
            long y = x;
            Console.WriteLine(y);

            int xx = (int)y; // explicit conversion
            Console.WriteLine(xx);

            //char to ASCII int and vice versa
            char ch = 'a';
            int intVal = ch;
            Console.WriteLine(intVal);

            char chh = (char)intVal;
            Console.WriteLine(chh);
        }

        static void solve5(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            int a = 2, b = 3;
            Console.WriteLine(2 + 3);
            Console.WriteLine(2 - 3);
            Console.WriteLine(2 * 3);
            Console.WriteLine(2 / 3);
            Console.WriteLine(2 % 3);
            Console.WriteLine(2 | 3);
            Console.WriteLine(2 ^ 3);
            Console.WriteLine(2 & 3);
        }

        static void solve6(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            int a = 2, b = 3;
            if (a < b) Console.WriteLine("a is greater than b.");
            else if (a > b) Console.WriteLine("b is greater than and");
            else Console.WriteLine("a and b are equal!");
        }

        static void solve7(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            string s = "";
            string t = "false";
            string T = "false";
            if((s.Length == 0 && t == "false") || T == "True")
            {
                Console.WriteLine("s is empty and t is \"false\".");
            }
        }

        static void solve8(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            int x = 0;
            string ans = (x == 0) ? "true" : "flase";
            Console.WriteLine(ans);
        }

        static void solve9(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            // single comment
            /* double line 
             * command */
        }

        static void solve10(int probNo) // loops ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            //for loop
            for(int i = 1; i < 101; i++)
            {
                if (i == 95) continue;
                if (i == 99) break;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //while loop
            int j = 0;
            while(j++ < 101)
            {
                if (j == 95) continue;
                if (j == 99) break;
                Console.Write(j + " ");
            }
            Console.WriteLine();

            //do... while loop
            int k = 0;
            do
            {
                k++;
                if (k == 99) break;
                if (k == 95) continue;
                Console.Write(k+" ");
            } while (k < 101);
            Console.WriteLine();

            //foreach loop
            List<int> list = new List<int>();
            for(int i = 1; i < 101; i++) { list.Add(i); }
            foreach(int i in list)
            {
                if (i == 95) continue;
                if (i == 99) break;
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void solve11(int probNo) // ----------------------------------
        {
            Console.WriteLine("\nsolution " + probNo + " :");
            string s = "Showrav";
            switch(s)
            {
                case "Rahim":
                    Console.WriteLine("No");
                    break;
                case "Karim":
                    Console.WriteLine("No");
                    break;
                case "Showrav":
                    Console.WriteLine(s);
                    break;
                default: Console.WriteLine("try again!");
                    break;
            }
        }
    }
}