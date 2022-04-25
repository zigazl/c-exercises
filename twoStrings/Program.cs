using System;

//Write a program to read two strings and report whether the strings are equal. If not, report
//which of the two is the larger. Now, change the program to report whether the strings
//have the same length and if not report which is longer.

namespace twoStrings {
    class Program {
        static void Main(string[] args) {
            
            
            Console.WriteLine("Enter string 1");
            var str1 = Console.ReadLine();

            Console.WriteLine("Enter string 2");
            var str2 = Console.ReadLine();

            if (str1 == str2) {
                Console.WriteLine("Strings are equal");
            } else if (str1.Length == str2.Length){
                Console.WriteLine("String sizes are the same");
            }
            else {
                if(str1.Length > str2.Length) {
                    Console.WriteLine("String 1 is larger");
                }
                else {
                    Console.WriteLine("String 2 is larger");
                }
            }

        }
    }
}
