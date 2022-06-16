using System;

namespace ParamsTest{
    class ParamsTest{
        static void Main(string[] args){
            PrintValues(5,3,4);
        }
        static void PrintValues(params int[] numbers){
            /*Meaning it treats the params as an array.
            however we need to type cast it to a string if we were to output
            the whole array no wonder we are using the single index arrays.*/
            Console.WriteLine(numbers[0]+""+numbers[1]+""+numbers[2]);
            Console.WriteLine("The array called numbers is supposed to be here:- \" {0} \" but since its not typecast either implicitly or explicitly it simply outputs some abnormal things",numbers);
        }
    }
}