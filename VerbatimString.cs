using System;

namespace VerbatimString{
    class VerbatimString{
        static void Main(string[] args){
            /* Escape sequences work for all strings except for
            the verbatim string which only allows for the 
            double quotations to be escaped. its done by repeating the 
            double quotes twice.*/
            string normalString = " I escape the \" marks here and the \\ character here";
            Console.WriteLine(normalString);
            /*precede your string with the @ symbol. */
            string verbatimString = @"I cant escape \* as well as the \\ symbol, only quotes with the "" ";
            Console.WriteLine(verbatimString);
        }
    }
}