using System;

namespace  ArrayListTest
{
    class ArrayListTest{
        static void Main(string[] args){
            ArrayListActual<string> testData = new ArrayListActual<string>();
            testData.Add("Tom");
            testData.Add("ToSmmy");
            testData.Add("Paul");
            testData.Add("Shan");
            testData.Add("Tony");
            testData.Add("Sunny");
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
            checkIfArrayFull();
            actualArray[this.count] = item;
            Console.WriteLine(item);
            this.count++;
            
        }
        public void checkIfArrayFull(){
            // add + 1 since count begins from 1, to prevent exceptions.
            if(this.count + 1 > this.actualArray.Length){
                T[] newArray = new T[this.actualArray.Length*2];
                // for copying the items of the actual Array into the new Array
                Array.Copy(this.actualArray,newArray,this.count);
                // for once again referencing the initial array to the extend array.
                this.actualArray = newArray;
            }
        }  
    }
}