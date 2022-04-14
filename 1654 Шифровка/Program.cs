using System;
using System.Collections.Generic;

namespace _1654_Шифровка {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < inputString.Length; i++) {
                if (stack.Count == 0) {
                    stack.Push(inputString[i]);
                }
                else {
                    if (inputString[i] == stack.Peek()) 
                        stack.Pop();
                    else 
                        stack.Push(inputString[i]);
                }
            }

            int j = 0;
            char[] charArray = new char[stack.Count];
            while (stack.Count > 0) {
                charArray[j++] = stack.Pop();
            }

            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }
}
