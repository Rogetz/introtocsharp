using System;

internal namespace ConsoleErrorWriteLineTest{
    class ConsoleErrorWriteTest{
        static void Main(string[] args){
            /*It just works  the same way as the Console.WriteLine method */
            Console.Error.WriteLine("AN INTENDED ERROR");
        }
    }
}