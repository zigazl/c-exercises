using System;
using System.Collections.Generic;

namespace textVector {

    //Read some text into a vector, storing each word in the input as an element in the vector.
    //Transform each word into uppercase letters.Print the transformed elements from the
    //vector, printing eight words to a line.

    class Program {
        static void Main(string[] args) {
            var text = new List<String>();
            var input = "a";
            string[] tmp;
            while(!String.IsNullOrEmpty(input)) {

                input = Console.ReadLine();

                input = input.ToUpper();
                tmp = input.Split(" ");
                foreach(var entry in tmp) {
                    text.Add(entry);
                }

            }

            for(var i = 0; i < text.Count; i++) {
                if(i % 8 == 0) {
                    Console.WriteLine();
                }
                Console.Write(text[i] + " ");
            }
        }
    }
}
