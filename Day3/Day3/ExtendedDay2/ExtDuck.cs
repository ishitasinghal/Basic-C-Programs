using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.ExtendedDay2
{
    public class Duck
    {
        public int weight { get; set; }
        public int wings { get; set; }
        public string type { get; set; }

        public virtual void Details() { }
    

    public class Rubber : Duck
    {
        public override void Details()
        {
            base.Details();
            Console.WriteLine("RUBBER DUCK");
            Console.WriteLine("Rubber ducks don’t fly and squeak.");
        }
    }
    public class Mallard : Duck
    {
        public override void Details()
        {
            base.Details();
            Console.WriteLine("MALLARD DUCK");
            Console.WriteLine("Mallard ducks fly fast and quack loud.");
        }
    }

    public class Redhead : Duck
    {
        public override void Details()
        {
            base.Details();
            Console.WriteLine("REDHEAD DUCK");
            Console.WriteLine("Redhead ducks fly slow and quack mild.");
        }
    }
    //public class ExtDuck
    //{
        public void MakeList(List<Duck> dlist)
        {
            
            Rubber rub = new Rubber();
            Mallard mal = new Mallard();
            Redhead rh = new Redhead();

            rub.weight = 24;
            rub.wings = 2;
            rub.type = "Rubber Duck";

            mal.weight = 30;
            mal.wings = 4;
            mal.type = "Mallard Duck";

            rh.weight = 35;
            rh.wings = 1
                ;
            rh.type = "Redhead Duck";

            Console.WriteLine("Adding Rubber duck\n");
            dlist.Add(rub);
            Console.WriteLine("Adding Redhead duck\n");
            dlist.Add(rh);
            Console.WriteLine("Adding Mallard duck\n");
            dlist.Add(mal);
            ShowList(dlist);
            Console.WriteLine("Removing Mallard Duck from the list....\n");
            dlist.Remove(mal);
            ShowList(dlist);
            dlist.Add(mal);
            Console.WriteLine("Iterating the list in increasing order of weights....\n");
            dlist = dlist.OrderBy(x => x.weight).ToList();
            ShowList(dlist);
            Console.WriteLine("Iterating the list in increasing order of wings....\n");
            dlist = dlist.OrderBy(x => x.wings).ToList();
            ShowList(dlist);

        }


        public void ShowList(List<Duck> dlist)
        {
            Console.WriteLine("ITEMS IN LIST\n");
            Console.WriteLine("DUCK TYPE | WINGS | WEIGHT");
            foreach(Duck d in dlist)
            {
                Console.WriteLine(d.type+" | "+d.weight+" | "+d.wings);
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadKey();
        }

        
    }

}

