using System;

namespace _2056_Стипендия {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            bool has3 = false;
            bool hasAll5 = true;
            int sum = 0;
            double average;

            for (int i = 0; i < n; i++) {
                int current = Convert.ToInt32(Console.ReadLine());
                sum += current;

                if (current == 3)
                    has3 = true;

                if (current != 5)
                    hasAll5 = false;
            }

            average = (double)sum / (double)n;

            if (has3)
                Console.WriteLine("None");
            else if (hasAll5)
                Console.WriteLine("Named");
            else if (average >= 4.5)
                Console.WriteLine("High");
            else
                Console.WriteLine("Common");

        }
    }
}
