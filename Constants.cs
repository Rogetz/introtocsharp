using System;

namespace ConstantTest{
    class ConstanTine{
        static void Main(string[] args){
            /*Dont use a public modifier if you have no other classes to
            use on it.*/
            const string Color = "blue";
            Console.WriteLine(Color);
        }
    }
}