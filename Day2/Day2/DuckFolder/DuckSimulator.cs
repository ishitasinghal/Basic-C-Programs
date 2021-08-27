using System;

namespace Day2.DuckFolder
{
    class DuckSimulator
    {
        enum DuckType { MallardDuck = 0, RedheadDuck = 1, RubberDuck = 2 };

        /// <summary>
        /// creating an interface for duck details
        /// </summary>


        public interface IDetails
        {
            void Detail();
        }
        class Duck : IDetails
        {
            private double wt;
            private int wings;
            private DuckType typeofduck;

            public Duck() { }

            public Duck(double wt, int wings, DuckType typeofduck)
            {
                this.wt = wt;
                this.wings = wings;
                this.typeofduck = typeofduck;
            }

            public virtual void Detail()
            {
                if (typeofduck == DuckType.RedheadDuck)
                {
                    Console.WriteLine("THE DUCK IS A REDHEAD");
                }
                if (typeofduck == DuckType.MallardDuck)
                {
                    Console.WriteLine("THE DUCK IS A MALLARD");
                }
                if (typeofduck == DuckType.RubberDuck)
                {
                    Console.WriteLine("THE DUCK IS A RUBBER DUCK");
                }
                Console.WriteLine("Wings : {0}", wings);
                Console.WriteLine("Weight of the duck : {0}", wt);
            }

        }

        //derived class 1
        class Rubber : Duck
        {
            public Rubber(double wt, int wings, DuckType typeofduck)
                : base(wt, wings, typeofduck)
            {


            }
            public override void Detail()
            {
                base.Detail();
                Console.WriteLine("Rubber ducks don’t fly and squeak.");
            }
        }
        //derived class 2
        class Mallard : Duck
        {
            public Mallard(double wt, int wings, DuckType typeofduck)
                : base(wt, wings, typeofduck)
            {


            }
            public override void Detail()
            {
                base.Detail();
                Console.WriteLine("Mallard ducks fly fast and quack loud.");
            }
        }
        //derived class 3
        class Redhead : Duck
        {
            public Redhead(double wt, int wings, DuckType typeofduck)
                : base(wt, wings, typeofduck)
            {


            }
            public override void Detail()
            {
                base.Detail();
                Console.WriteLine("Redhead ducks fly slow and quack mild.");
            }
        }


        public DuckSimulator()
        {

            IDetails[] ducks = new IDetails[3];
            ducks[0] = new Mallard(10, 2, DuckType.MallardDuck);
            ducks[1] = new Redhead(14, 4, DuckType.RedheadDuck);
            ducks[2] = new Rubber(5, 0, DuckType.RubberDuck);


            for (int i = 0; i < 3; i++)
            {
                ducks[i].Detail();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

