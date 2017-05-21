using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz {
    class Program {
        static void Main(string[] args) {
            for (int i = 1; i < 101; i++) {
                string output = "" + i;
                if (i % 3 == 0) {
                    output = "Fizz";
                }
                if (i % 5 == 0) {
                    output = "Buzz";
                }
                if (i % 5 == 0 && i % 3 == 0) {
                    output = "FizzBuzz";
                }
                Console.Out.WriteLine(output);

            }
            Console.Read();
        }
    }
}
