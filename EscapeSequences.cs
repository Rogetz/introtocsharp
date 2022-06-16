using System;

namespace EscapeSequences{
    class EscapeSequences{
        static void Main(string[] args){
            /*Escaping special charcters in csharp*/
            char a = '\"';
            char backslash = '\\';
            /*the n here displays creates a new line
            since its literal meaning here would have been n
            if escaped it doesnt output n.
            And I think this is a pretty good insight on escape
            sequences that they actually represent the
            viceversa of the literal meaning of something.*/
            char newLine = '\n';
            char characterCode = '\u03A7';
            /*The various escaped values are as follows:-*/
            Console.WriteLine("The character Quote{0},the backslash  {1}, the newLine  {2},the characterCode  {3}",a,backslash,newLine,characterCode);
        }
    }
}