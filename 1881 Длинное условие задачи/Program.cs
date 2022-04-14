using System;

namespace _1881_Длинное_условие_задачи {
    class Program {
        static void Main(string[] args) {
            var str = Console.ReadLine();
            string[] stringDigitArray = str.Split(new[] { ' ' });

            int h = Convert.ToInt32(stringDigitArray[0]);
            int w = Convert.ToInt32(stringDigitArray[1]);
            int n = Convert.ToInt32(stringDigitArray[2]);

            int page = 1;
            int line = 1;
            int left = w;
            int currentStringSize;

            string currentString;

            for (int i = 1; i <= n; i++) {
                currentString = Console.ReadLine();
                currentStringSize = currentString.Length;

                if (currentStringSize > left) {
                    line++;
                    if (line > h) {
                        line = 1;
                        page++;
                    }
                    left = w - currentStringSize - 1;
                }
                else {
                    left = left - currentStringSize - 1;
                }
            }

            Console.WriteLine(page);
        }
    }
}
