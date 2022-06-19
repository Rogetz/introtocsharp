using System;

namespace  ArrayListTest
{
    class ArrayListTest{
        static void Main(string[] args){
            ArrayListActual<string> testData = new ArrayListActual<string>();
            testData.Add("Tom");
        }
    }
    public class ArrayListActual <T>{
        private T[] actualArray;
        private int count;

        // default capacity;
        private const int DEFAULT_CAPCITY = 4;

        public ArrayListActual(int size = DEFAULT_CAPCITY){
            this.actualArray = new T[size];
            this.count = 0;
        }

        public void Add(T item){
            actualArray[count] = item;
            Console.WriteLine(item);
            this.count++;
            // my own implementation such that it tests whether the next iteration would be greater than
            // the size of the array.
            checkIfArrayFull();
        }
        public void checkIfArrayFull(){
            if(this.count > this.actualArray.Length){
                T[] newArray = new T[this.actualArray.Length*2];
                // for copying the items of the actual Array into the new Array
                Array.Copy(this.actualArray,newArray,this.count);
                // for once again referencing the initial array to the extend array.
                this.actualArray = newArray;
            }
        }  
    }
}