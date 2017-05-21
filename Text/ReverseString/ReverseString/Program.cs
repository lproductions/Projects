using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            
            int j = 0;
            StringBuilder sb = new StringBuilder(input);
            
            for(int i = input.Length -1; i>=0; i--){
                
                sb[j] = input[i];
                j++;

            }
            Console.Out.WriteLine(sb.ToString());
            
            Console.ReadLine();

        }
    }
}
