using System;
using ClassDemo_LinkedList10_15.Classes;

namespace ClassDemo_LinkedList10_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(7);

            LList myAwesomeList = new LList(node1);

            myAwesomeList.Print();
        }
    }
}
