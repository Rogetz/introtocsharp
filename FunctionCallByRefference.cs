using System;

namespace CallByRefference{
    class CallByRefference{
        static void Main(string[] args){
            /*Calling it by refference*/
            /*note we use colon : to assign and not = sign */
            Refferential(name: "Paul", age: 18);
        }
        static void Refferential(string name, int age, int stream = 1){
            Console.WriteLine("Function call by refference results:-");
            Console.WriteLine("The name: {0}, age: {1} and stream: {2}",name,age,stream);
        }
    }
}