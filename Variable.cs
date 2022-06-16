using System;

namespace Variable{
    class PrimitiveTypeTest{
        /*main in capital.*/
        static void Main (string[] args){
            /*Variable types in small letters*/
            /*Primitive type*/
            /*5 is a literal here.
            Literals are values assigned to the type at declaration.*/
            int i = 5;
            /*Methods are capital in C*/
            Console.WriteLine(i);
            i = 10;
            Console.WriteLine(i);
            /*I've reassigned i, meaning in csharp,
            you can always reassign primitive values.
            Only difference with reference types is that
            they dont change the address they reassign the addres
            to another value unlike the primitive types.*/

            /*Refference type*/
            object j = 20;
            Console.WriteLine(j);
            j = 50;
            Console.WriteLine(j);
            /*Objects are useful when you want to define a function
            that really accepts any type of parameter.*/
        }
    }
}