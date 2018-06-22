using System;

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
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
        }
    }
}
