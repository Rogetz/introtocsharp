using System;
using System.Text;

namespace StringBuilderTestTwo{
    class StringBuilderTest{
        static void Main(string[] args){
            /*Include the Text namespace at the top */
            StringBuilder name = new StringBuilder();
            name.Append("Ronny");
            Console.WriteLine(name);
            name.Append("Odhiambo");
            Console.WriteLine(name);
            /*Note that it uses the index in terms of letters.*/
            name.Insert(2,"  Inserted Name");
            Console.WriteLine(name);
        }
    }
}