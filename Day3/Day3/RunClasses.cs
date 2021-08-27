using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day3.CollectionsGenerics;
using Day3.ExtendedDay2;

namespace Day3
{
    internal class RunClasses
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to run priority queue program way 1");
            Console.WriteLine("Enter 2 to run extended Equipment program");
            Console.WriteLine("Enter 3 to run extended duck program");
            Console.WriteLine("Enter 4 to run priority queue program way 2");
            Console.WriteLine("Enter 5 to run priority queue program way 3");



            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Running case 1....");
                    PqueueWay1<int> pq = new PqueueWay1<int>();
                    pq.Enqueue(1, 2);
                    pq.Enqueue(3, 4);
                    pq.Enqueue(5, 6);
                    Console.WriteLine("\nPerforming Peek..."+ pq.Peek());
                    Console.WriteLine("\nPerforming Dequeue...");
                    pq.Dequeue();
                    Console.WriteLine("\nPerforming Peek..." + pq.Peek());

                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("Running case 2....");
                    ExtEquipment eqp = new ExtEquipment();
                    List<Equipment> a = new List<Equipment>();
                    for(int i=0;i<2;i++)
                        eqp.create(a);
                    eqp.create(a);
                    eqp.show(a);
                    eqp.delete(a);
                    eqp.show(a);

                    break;

                case "3":
                    Console.WriteLine("Running case 3....");
                    Duck ed = new Duck();
                    List<Duck> dlist = new List<Duck>();
                    ed.MakeList(dlist);
                    

                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }

}
