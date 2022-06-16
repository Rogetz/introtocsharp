using System;
using System.Text;

namespace CapitalLetters{
    class CapitalLetters{
        static void Main(string[] args){
            string name = "I Am Not In South aftrica";
            string extractedName = name.Substring(2,10);
            Console.WriteLine("Test for the ToLower() function of the string which converts the A and the N in the substring \"{0}\" of the name To:    {1}",extractedName,extractedName.ToLower());
            CapitalLettersFinder(name);
            /*The IsUpper Method is used by calling the char keyword. and
            passing the char as a parameter.*/
            Console.WriteLine(char.IsUpper(name[0]));/*returns boolean true or false. */
        }
        static void CapitalLettersFinder(string value){
            StringBuilder result = new StringBuilder();
            StringBuilder actualResult = new StringBuilder();
            actualResult.Append("The actual modified result is: ");
            bool test = true;
            int capitalCount = 0;
            foreach(char letter in value){
                test = char.IsUpper(letter);
                if(test == true){
                    capitalCount += 1;
                    char lowerCase = char.ToLower(letter);/* uses the char class for the function,
                    I guess its because its a norm for the primitive types.*/
                    /*Record the index to know where to insert it*/
                    actualResult.Append(lowerCase);
                }else{
                    actualResult.Append(letter);
                }
                
            }
            result.Append("The unfinished result");
            Console.WriteLine(actualResult);
            Console.WriteLine(result.ToString());
            Console.WriteLine(capitalCount);
        }
    }
}