using System;
using System.Collections.Generic;

namespace DuckOverride
{
    class Program
    {
        public bool Running = true;

        static void Main(string[] args)
        {
            var prog = new Program();
            prog.Run();
        }

        public void Run()
        {
            //ducks
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var qq = new Duck("Quacknotsomuch", "Mallard", 100, 17);
            var nq = new Duck("Sir Quackalot", "Mallard", 101, 17);

            //testing equality overrides
            Console.WriteLine(quack == qq);//Expected True
            Console.WriteLine(quack != qq);//Expected False
            Console.WriteLine(quack == nq);//Expected False
            Console.WriteLine(quack != nq);//Expected True

            //Sorting a list of Ducks into order
            var x = new List<Duck>();
            x.Add(quack);
            x.Add(qq);
            x.Add(nq);

            x.Sort();

            //Using the Duck as the key in a Dictionary
            var ducktionary = new Dictionary<Duck, int>();
            foreach (var duck in x)
            {
                ducktionary.Add(duck, duck.GetHashCode());
            }


            //END
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
