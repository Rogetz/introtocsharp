using System;

namespace ReadLineTest{
    class ReadLineTest{
        static void Main(string[] args){
            /*In c sharp unless its a string you parse the input to 
            whatever type you want before you assign it to any variable
            type, because it comes as string.*/
            Console.WriteLine("input an integer value");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The integer input value is : {0}",input1);
            Console.WriteLine();
            Console.WriteLine("Input a string value");
            string input2 = Console.ReadLine();
            Console.WriteLine("The string input is : {0}",input2);
        }
    }
}