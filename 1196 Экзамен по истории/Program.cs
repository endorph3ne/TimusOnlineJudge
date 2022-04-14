using System;
using System.Collections.Generic;

namespace _1196_Экзамен_по_истории {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrayPrep = new int[n];
            for (int i = 0; i < n; i++) 
                arrayPrep[i] = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());
            int[] arrayStud = new int[m];
            for (int i = 0; i < m; i++)
                arrayStud[i] = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            List<int> list = new List<int>();
            for (int i = 0; i < arrayPrep.Length; i++) {
                if (!list.Contains(arrayPrep[i])) 
                    list.Add(arrayPrep[i]);
            }

            Array.Sort(arrayStud);

            foreach (int current in list) {
                int index = Array.FindIndex(arrayStud, x => x == current);
                if (index == -1)
                    continue;
                else {
                    count++;
                    index++;
                }

                //if (index != -1) {
                //    count++;
                //    index++;
                //}

                
                while (arrayStud[index++] == current) {
                    count++;
                }

            }         

            Console.WriteLine(count);
        }
    }
}
