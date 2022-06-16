using System;

namespace CharType{
    class CharType{
        static void Main(string[] args){
            /*Value of a character can be a character code.*/
            char i = '\u0065';
            /*Note that the character code has been escaped in order for it to be 
            output.*/
            Console.WriteLine("The value of the character code:- "+i);
            char j = 'A';
            Console.WriteLine("The value of the char value:- "+j);
            /*Literals are values assigned at declaration*/
        }
    }
}