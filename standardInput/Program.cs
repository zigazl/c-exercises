using System;
using System.Text;



namespace standardInput {
    class Program {
        static void Main(string[] args) {
            var sb = new StringBuilder();
            string input = "f";

            while (!string.IsNullOrEmpty(input)) {
                input = Console.ReadLine();
                sb.Append(input + " ");
            }

            Console.WriteLine(sb);

        }
    }
}
