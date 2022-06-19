using System;
// for the input output exceptions.

namespace LinkedListTester{
    public class LinkedListTester{
        static void Main(string[] args){
            // ALWAYS REMEMBER TO declare the try  catch block in the Main method of
            // the class.
            try
            {
                // instantiATING the generic class.
                // note that it also takes primitive types as parameters.
                ImplementedLinked<int> testerVariable = new ImplementedLinked<int>();
                // using Adding method cause I dont want to be in a situation whereby 
                // am using an implemented method.
                testerVariable.Adding(5);
            }
            catch (System.Exception e)
            {
                Console(e.Message);
            } 
        }
    }
    public class ImplementedLinked <T>{
        // class variables, To be initialized in the constructor.;
        Node head;
        Node tail;
        int count;
        //The Node class, the core
        private class Node{
            // no need for a semicolon after using the accessor method.
            // avoid using the get;set technique, its very useless, use the full definition.
            /*Once an element is declared public it doesnt need the get and set accessor
            methods, unless its setting elememnts for anothern PRIVATE element.
            By default c# creates a get and set method for all public fields*/
            public T nodeElement;
            public Node nextNode;
            public Node(T element){
                this.nodeElement = element;
                nextNode = null;
            }
            public Node(T element, Node prevNode){
                this.nodeElement = element;
                prevNode.nextNode = this;
            }
        }
        //The constructor doesnt need to have the <T> IN ITS DECLARATION, AS CONMPARED TO THE CLASS.
        public ImplementedLinked(){
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        //The first mehod, Adding method.
        public void Adding(T element){
            if(this.head == null){
                this.head = new Node(element);
                this.tail = this.head;
            }
            else{
                Node newNode = new Node(element, this.tail);
                this.tail = newNode;
            }
            this.count++;
            Console.WriteLine(this.tail.nodeElement);
        }
        // the second method, Removing method. I've given it a return type
        // cause in real life it actually returns the removed value.
        public T RemovingAt(int index){
            T result;
            Node prevNode = null;
            Node currentNode = this.head;
            int indexCount = 0;
            // the index mustn't be greater thab the indexCount.
            while(index != null){
                // test whether its greater than the overral count of the linkedList class.
                if(index > count){
                    throw new System.Exception("INVALID INDEX BRO");
                }
                else if(index == 0){
                    T result = this.head.nodeElement;
                    RemovingActual(prevNode,this.head); 
                }
                else if(index == indexCount){
                    prevNode = currentNode;
                    currentNode = currentNode.nextNode;
                    T result = currentNode;
                    RemovingActual(prevNode,currentNode);
                    // code for breaking out of the loop.
                    break;
                }
                else{
                    indexCount++;
                    prevNode = currentNode;
                    currentNode = currentNode.nextNode;
                }
            }
        }
        public void RemovingActual(Node prevNode, Node currentNode){
            // if the previous node is 0 it simply means that its the head that we are removing
            // so we also have to give the  head a new value.
            if(prevNode == null){
                this.head = currentNode.nextNode;
                currentNode = this.head.nextNode;
                /// remember that the main goal of this method is  to change where the prevNode points to.
                this.head.nextNode = currentNode;
            }
            else{
                prevNode.nextNode = currentNode.nextNode; 
            }
        }
    }

}