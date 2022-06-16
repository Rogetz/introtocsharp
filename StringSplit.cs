using System;
/*String is not a namespace so it can't be applied to a using keyword.*/

namespace  StrningSplit
{
    class StringSplit
    {
        /*The split function is like the join function in javascript.
        Similarity is that they are both used to convert the string to the array
        with a split function.*/
        static void Main(string[] args){
            string texts = "I am a boy";
            /*We use single quotation marks in the Split function cause the parameters are an array of
            characters.*/
            /* The Split function is essensial in splitting the substrings of a text
            by the given Characters, or character*/
            char[] symbols = new char[]{',','.'};
            string[] splittedTexts = texts.Split(symbols);
            foreach(string text in splittedTexts){
                Console.WriteLine(text);
            }
            Console.WriteLine(String.Join(",",splittedTexts));
        }
    }
}