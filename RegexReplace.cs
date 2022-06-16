using System;
using System.Text.RegularExpressions;

namespace RegexReplace{
    /*Ensure that your class names dont confilict with the 
    inbuilte keywords such as Regex, it almost brought me huge problems here.*/
    class RegexTest{
        static void Main(string[] args){
            /*Regex can be used to hide senasitive data.*/
            string details = "Toms Number: 0748554123, Otienos Number: 0714565412, Reubens number: 0766578915";
            /*Note that only the Text is a namespace.*/
            /*Remember to include the System.Text.RegularExpressions at the top.*/
            /*Remeber that regexes in c# are escaped using the fromtslash and not
            the backslash.*/
            /*in c# the $ symbol is used to signify the begining unlike in php
            whereby ^ is used for the begining.*/
            /*Here we've used groups which are enclosed in brackets. So the 
            symbol $1 means 1st group. Meaning only the first group it encounters
            will be displayed.*/
            string hiddenData = Regex.Replace(details,"(07)[0-9](8)","$1********");
            /*I need to know the regex modifiers in c# that can ensure that I replace
            the regex pattern more than once cause this one doesnt*/
            Console.WriteLine(hiddenData);
        }        
    }
}