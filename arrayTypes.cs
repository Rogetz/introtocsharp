using System;
/*research more about the linq class, am not sure whether its a namespace or a class.*/
using System.Linq;

namespace ArrayTypes{
    class ArrayTypes{
        static void Main(string[] args){
            /*One dimensional arrays*/
            int[] arrayOne = new int[5];
            for(int i = 0; i < 5 ; i++){
                Console.WriteLine("Enter an integer value for the array.");
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array index 0 is : {0}",arrayOne[0]);
            /*The Select method here is linqs enumerable method iterator that allows individual selection
            of items in a single Dimensional array not a multidimensional.*/
            /*1st Conversion of the integer array to the string array.*/
            string[] arrayTwo = arrayOne.Select(i => i.ToString()).ToArray();
            /*second now conversion of the string array to a string using the String class
            object*/
            Console.WriteLine(String.Join(",",arrayTwo));
            /*Note that this simply changes the value type of each value in the array to 
            a string but then its still an integer array.
            So you need to convert it to an array using the ToString() array method*/
            Console.WriteLine("Note that the Select Method used here:-   {0}   simply changes the value type of each value in the array to a string but then it still is an integer array.",arrayOne.Select(i => i.ToString()));


            /*normal multidimensional arrays.*/

            int[,] multiDimensionalOne = new int[2,3];
            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine("Enter column array value for row: {0}",i);
                    /*note that we access it using commas, not two square brackets.*/
                    multiDimensionalOne[i,j] = int.Parse(Console.ReadLine());
                }
            }
            /*The values are counted individually here and not as an array, thats why
            I have used type int and not an int array */
            int c = 0;
            /*creating the string array(you must initalize it for use.)*/
            string[] multiTwo = new string[6];
            foreach(int value in multiDimensionalOne){
                /*output each value*/
                Console.WriteLine(value);
                /*trying to convert each individual integer to a string first then storing it to a
                string array.*/
                
                /*you must first define an array i.e giving it memeory allocation, before trying to access
                anything related to it.*/
                multiTwo[c++] = value.ToString();
            }
            Console.WriteLine(String.Join(",",multiTwo));
            /*string[] multiTwo = multiDimensionalOne.Select(i => i.ToString()).ToArray();*/
        }
    }
}