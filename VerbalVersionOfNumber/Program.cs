using System;

namespace VerbalVersionOfNumber
{
    enum Numbers1
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,

    }

    enum Numbers2
    {
        eleven = 11,
        twelve = 12,
        thirteen = 13,
        fourteen = 14,
        fifteen = 15,
        sixteen = 16,
        seventeen = 17,
        eighteen = 18,
        nineteen = 19,

    }
    enum Numbers3
    {
        twenty = 2,
        thirty = 3,
        fourty = 4,
        fifty = 5,
        sixty = 6,
        seventy = 7,
        eighty = 8,
        ninety = 9,

    }

    static class Class
    {
        public static void FindNumber(this int a)
        {
            int[] b = new int[a.ToString().Length];
            int[] x = { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            string s = "";
            bool v = false;

            if (a.ToString().Length == 3)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    b[i] = a % 10;
                    a = a / 10;

                }


                s = $"{(Numbers1)b[0]} hundreed";

                for (int i = 0; i < x.Length; i++)
                {
                    if (Convert.ToInt32((b[1].ToString() + b[2].ToString())) == x[i])
                    {

                        v = true;
                    }
                }

                if (v)
                {
                    s = s + " " + $"{(Numbers2)Convert.ToInt32(b[1].ToString() + b[2].ToString())}";
                }
                else
                {
                    s = s + " " + (Numbers3)b[1] + " " + (Numbers1)b[2];
                }

                Console.WriteLine(s);
            }
            else if (a.ToString().Length == 2)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    b[i] = a % 10;
                    a = a / 10;

                }

                for (int i = 0; i < x.Length; i++)
                {
                    if (Convert.ToInt32((b[0].ToString() + b[1].ToString())) == x[i])
                    {

                        s = s + " " + $"{x[i]}";
                    }
                    else
                    {
                        v = true;
                    }
                }
                if (v)
                {
                    s = s + " " + (Numbers3)b[0] + " " + (Numbers1)b[1];
                }
                Console.WriteLine(s);
            }
            else if (a.ToString().Length == 1)
            {
                s = s + (Numbers1)a;
                Console.WriteLine(s);
            }



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            385.FindNumber();
        }
    }
}

