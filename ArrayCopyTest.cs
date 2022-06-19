using System;

namespace ArrayCopyTest{
    class ArrayCopyTest
    {
        static void Main(string[] args){
            string[] names = new string[]{"paul","John","Tom"};
            string[] extendedNames = new string[names.Length*2];
            // the Array.Coppy method takes on three arguments one being the innitial array,
            // the other being the extended array and the last being the number of values to be 
            // copied.
            Array.Copy(names,extendedNames,3);
            // the Copy function copies all the values to the extended array and 
            foreach(string name in extendedNames){
                Console.WriteLine(name);
            }
            //now you can then
            // reassign the original names array to refer to the extended names.
            names = extendedNames;
            foreach(string name in names){
                Console.WriteLine(name);
            }   
        }
    }
}