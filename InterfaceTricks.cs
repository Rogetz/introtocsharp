using System;

namespace InterfaceTest{
    class InterfaceTest{
        /*any method declared in it can not be 
    defined by any class that does not implement it*/
        static void Main(string[] args){
            AnimalQualities Dog = new AnimalQualities();
            Dog.Roar();
        }
    }
    /*Interface must be outside a class.*/
    interface IRoar{
        /*An interface with two methods.*/
        void Roar();
        void laugh();
    }
    /*Advanntage of an interface is that any method declared in it can not be 
    defined by any class that does not implement it.*/
    /*So you must implement it first using the : symbol in order to use it.*/
    class AnimalQualities : IRoar{
        /*always remember to include the public keyword in the implementing class
        cause by default its declared public in the interface. The method in the 
        implementing class must be similar in all properties to the one in the
        interface for it to be able to implement from it.*/
        public void Roar(){
            Console.WriteLine("I can roar");
        }
        /*A class that implements a specific interface must define all the methods
        in the interface.*/
        public void laugh (){
            Console.WriteLine("I can laugh");
        }
    }
}