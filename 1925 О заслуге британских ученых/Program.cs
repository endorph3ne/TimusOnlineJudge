using System;

namespace _1925_О_заслуге_британских_ученых {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int k = Convert.ToInt32(input[1]);

            string[] currentInput;
            int sumB = 0;
            int sumG = 0;

            for (int i = 0; i < n; i++) {
                currentInput = Console.ReadLine().Split(' ');
                sumB += Convert.ToInt32(currentInput[0]);
                sumG += Convert.ToInt32(currentInput[1]);
            }

            if (sumB + k < 2) {
                Console.WriteLine("Big Bang!");
            }
            else {
                int totalSum = sumB + k;
                int yearDiff = (2 * (n + 1));

                int a = totalSum - yearDiff;

                if (a - sumG > 0) {
                    Console.WriteLine(a - sumG);
                }
                else {
                    Console.WriteLine("Big Bang!");
                }
            }
        }
    }
}
