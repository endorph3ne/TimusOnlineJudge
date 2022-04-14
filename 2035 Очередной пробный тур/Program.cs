using System;

namespace _2035_Очередной_пробный_тур {
    class Program {
        static void Main(string[] args) {
            string[] stringArray = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(stringArray[0]);
            int y = Convert.ToInt32(stringArray[1]);
            int c = Convert.ToInt32(stringArray[2]);


            Console.WriteLine(find(x, y, c));
        }

        static string find(int x, int y, int c) {
            if (x < c && y < c) {
                if (x + y < c)
                    return "Impossible";
                else
                    return x + " " + (c - x);
            }
            else if (x > c && y < c) {
                return (c - y) + " " + y;
            }
            else if (x < c && y > c) {
                return x + " " + (c - x);
            }
            else {
                return c + " " + 0;
            }
        }
    }
}
