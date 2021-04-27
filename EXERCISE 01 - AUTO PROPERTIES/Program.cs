using System;
namespace EXERCISE_01___AUTO_PROPERTIES
    class Program {
        //-----> START
        ////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args) {
            Product p = new Product("tv", 500, 10);
            p.Name = "TV 4K";
            
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            }
        ////////////////////////////////////////////////////////////////////////////////////////////
        //-----> END
    }
}