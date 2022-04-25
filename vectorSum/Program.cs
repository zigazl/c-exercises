using System;
using System.Collections.Generic;

//Read a set of integers into a vector. Calculate and print the sum of each pair of adjacent
//elements in the vector. If there is an odd number, tell the user and print the value of the
//last element without summing it. Now change your program so that it prints the sum of
//the first and last elements, followed by the sum of the second and second-to-last and so
//on.
//A good replacement for C++ vector in C# is a list

namespace vectorSum {
    class Program {

        static void SumAdjecent(int sum, List<int> numbers) {
            for(var i = 0; i < numbers.Count; i += 2) {
                sum = numbers[i] + numbers[i + 1];
                Console.Write(sum + " ");
            }
        }

        static void Main(string[] args) {
            var numbers = new List<int>();
            var input = 0;
            var sum = 0;
            while(Int32.TryParse(Console.ReadLine(), out input)) {
                numbers.Add(input);
            }


            if(numbers.Count % 2 == 0) {
                SumAdjecent(sum, numbers);
                for(var i = 0; i < numbers.Count / 2; i++) {
                    var num1 = numbers[i];
                    var num2 = numbers[numbers.Count - 1 - i];
                    sum = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + sum);
                }

            }
            else {
                Console.WriteLine("The number of elements is odd");
                SumAdjecent(sum, numbers);
                for(var i = 0; i <= numbers.Count / 2; i++) {
                    var num1 = numbers[i];
                    var num2 = numbers[numbers.Count - 1 - i];
                    sum = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + sum);
                    if(i == numbers.Count / 2) {
                        Console.WriteLine("The middle number is: " + numbers[i + 1]);
                    }
                }
                Console.WriteLine("The last number of the list is " + numbers[numbers.Count - 1]);

            }
        }

    }
}

