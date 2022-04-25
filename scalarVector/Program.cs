using System;
using System.Collections.Generic;

namespace scalarVector {

    //Write a program to create a vector with 10 elements.Using an iterator, assign each
    //element a value that is twice its current value.Test your program by printing the vector.

    class Program {
        static void Main(string[] args) {
            var r = new Random();
            var vector = new List<int>();

            for(var i = 0; i < 10; i++) {
                vector.Add(r.Next(100));
            }

            foreach(var v in vector) {
                Console.Write(v + " ");
            }
            Console.WriteLine();
            foreach(var v in vector) {
                Console.Write(v * 2 + " ");
            }
        }
    }
}
