using System;
using System.Collections.Generic;

namespace _1496_Спамер {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            List<string> foundList = new List<string>();

            for (int i = 0; i < n; i++) {
                string current = Console.ReadLine();
                if (list.Contains(current)) {
                    if (!foundList.Contains(current))
                    foundList.Add(current);
                }
                else
                    list.Add(current);
            }

            foreach (string current in foundList)
                Console.WriteLine(current);
            Console.Read();
        }
    }
}
