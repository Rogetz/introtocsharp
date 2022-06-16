using System;

namespace NormalRegex{
    class NormalRegex{
        static void Main(string[] args){
            string fullName = "My name is Ronny the last one is Odhiambo";
            /*The modified Name: */
            string Modified = fullName.Replace("Ronny","Rogetz");
            /*worked perfectly.*/
            Console.WriteLine(Modified);
            /*Try it with two parameters*/
            /*It can not replace two characters at different positions
            It can only Replace Ronny Odiambo if it appears as so in the text.
            Thats why we need the RegexReplace.*/
            /*This plain Replace doesnt support Regex expressions.*/
            string modifiedTwo = fullName.Replace("Ronny Odhiambo","Rogetz Ojiambo");
            Console.WriteLine(modifiedTwo);
        }
    }
}