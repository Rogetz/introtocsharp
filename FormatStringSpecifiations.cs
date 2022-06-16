using System;

namespace FormatStingSpecifications{
    class FormatStingSpecifications{
        static void Main(string[] args){
            int i = 5023;
            /* NOTE HOW THE COLON IS ADDED AFTER THE INDEX OF THE
            FORMAT ARRAY.*/
            Console.Write("The digit specification would be:-  {0:D8}",i);
            /*The d is mostly used to specify the minimum requirements 
            of a number. If it doesnt meet, zeros are addded.*/
            float j = 52.58454f;
            /*Note that the Write function uses the new tab symbol inorder
            to create a new line, unlike the write line which writes one
            line and creates a new tab */
            Console.Write("\nThe decimal specificaction uses the E IN THE FORMAT SPECIFICATION:-  {0:E2}",j);
            /* the best specification is the symbol one, whereby # stands for
            any digit being output*/
            float h = 502.45684f;
            Console.Write("\n using symbol formats would be:- {0:##.##}, or {0:###}, or even add percentage symbol:- {0:%##} which works abnormally ofcourse,\nTake note of how am using the 0 index in all of the three array index\narray specifications, meaning you can use it more than once.", h);

        }
    }
}