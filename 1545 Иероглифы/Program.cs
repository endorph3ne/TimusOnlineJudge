using System;
using System.Collections.Generic;

namespace _1545_Иероглифы {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++) {
                list.Add(Console.ReadLine());
            }

            string key = Console.ReadLine();

            foreach (string current in list) {
                if (current.StartsWith(key))
                    Console.WriteLine(current);
            }
        }

    }
}

