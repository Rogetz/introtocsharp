using System;

namespace VariableTypes{
    class Variables{
        static void Main (String[] args){
            /*difference between  different leveles is always 8bits*/
            double b = 20.5;/*64bits*/
            /*float needs an f suffix always.*/
            float c = 13.2f;/*32 bits*/
            /*integer types begin from byte, short, int , long 
            and note that they can either be signed or unsigned.
            signed meaning they have both negative and non negatives
            Unsigned meaning they have only the positive side which makes them
            have a greater positive side value.*/
            byte  d = 12;
            short e = 305;
            int f = 0123545;
            long g = 131;
            sbyte h = -46;
            /*bYTE IS NATURALLY UNSIGNED YOU DONT NEED TO UNSIGN IT.*/
            byte i = 120;
            
            ushort j = 25555;
            /*The other integer types are signed by default except byte which is unsigned. */
            short k = -2555;
            ulong l = 58946316166115;
            Console.WriteLine("byte {0}, signedByte {1}, short {2}, unsignedShort {3}, long {4}, unsignedLong {5},",
            d,h,k,j,g,l);
            /*An error can also occur if you use large amount of data in the wrong type
            dmending for implicit conversion.
            so just know you've used it wrongly or sometinmes like the float type you have to suffiix it
            with an f.*/
        }
    }
}