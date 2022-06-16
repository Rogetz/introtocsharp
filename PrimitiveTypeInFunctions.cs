using System;

namespace PrimitiveInFunctions{
    class PrimitiveInFunctions{
        static void Main(string[] args){
            /*Primitive functions remain the same even after being passed in
            a function, because only their value is copied, not  the address.*/
            Console.WriteLine("Primitive functions remain the same even after being passed in a function, because only their value is copied, not  the address.");
            int first = 20;
            Console.WriteLine("integer before modification: {0}",first);
            Modifier(first);
            Console.WriteLine("the integer after modification: {0}",first);
        }
        static void Modifier(int mod){
            mod = 10;
        }
    }
}