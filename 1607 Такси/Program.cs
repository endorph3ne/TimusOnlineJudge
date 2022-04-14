using System;

namespace _1607_Такси {
    class Program {
        static void Main(string[] args) {
            var str = Console.ReadLine();
            string[] stringArray = str.Split(new[] { ' ' });

            int a = Convert.ToInt32(stringArray[0]);
            int b = Convert.ToInt32(stringArray[1]);
            int c = Convert.ToInt32(stringArray[2]);
            int d = Convert.ToInt32(stringArray[3]);
            int result = 0;

            if (a > c) {
                Console.WriteLine(a);
                return;
            }
                
            if (c < a) {
                Console.WriteLine(c);
                return;
            }
                

            while (true) {
                if (a + b < c)
                    a += b;
                else {
                    result = c;
                    break;
                }

                if (c - d > a) {
                    c -= d;
                }
                else {
                    result = a;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
