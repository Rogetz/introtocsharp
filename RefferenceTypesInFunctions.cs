using System;
using System.Linq;

namespace RefferenceTypesInFunctions{
    class RefferenceTypes{
        static void Main(string[] args){
            /*refference types refer to the address and not the value. */
            /*refference types include arrays, objects and pointers in c#*/
            int[] firstArray = new int[]{5,2,4};
            /*initial array output*/
            string[] initialArray = firstArray.Select(i => i.ToString()).ToArray(); 
            Console.WriteLine("initial Array : {0}",String.Join(",",initialArray));
            Modifier(firstArray);
            /*You'll notice that after passing the firstArray as a parameter 
            to the modifier, when you once again print it, its different*/
            string[] secondArray = firstArray.Select(i => i.ToString()).ToArray(); 
            Console.WriteLine("array after modification : {0}",String.Join(",",secondArray));

        }
        static void Modifier(int[] arr){
            arr[0] = 10;
        }
    }
} 