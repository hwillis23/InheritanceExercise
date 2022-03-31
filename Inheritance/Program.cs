using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // **Create a class Animal -DONE
            // **give this class 4 members that all Animals have in common-DONE


            // **Create a class Bird-DONE
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // **Create a class Reptile-DONE
            //** give this class 4 members that are specific to Reptile -DONE
            // **Set this class to inherit from your Animal Class



            /***Create an object of your Bird class and Reptile class -DONE
             *  **give values to your members using the object of your Bird class and Reptile class -DONE
             *  
             *  
             * Creatively display the class member values 
             */

            var hannahBird = new Bird();      ///dot notation

            hannahBird.CanFly = true;
            hannahBird.WingSpane = 14;
            hannahBird.CanTalk = true;
            hannahBird.WingColor = $"blue";

            var hannahCobra = new Reptile()   ///Object initializer
            {
                PoisionousOrNot = true,
                Lifespan = 10,
                Length = 36,
                TypeOfHabitat = $"desert"
            };

                Console.WriteLine($"Can this bird fly: {hannahBird.CanFly}");
                Console.WriteLine($"How long are this bird's wings:{hannahBird.WingSpane} inches long.");
                Console.WriteLine($"Can this bird talk: {hannahBird.CanTalk}, just like Tweety Bird.");
                Console.WriteLine($"What color is this bird's wings:{hannahBird.WingColor}.");
            Console.WriteLine();

            Console.WriteLine($"Is this snake posionous:{hannahCobra.PoisionousOrNot}");
            Console.WriteLine($"How long can the snake live:{hannahCobra.Lifespan} years.");
            Console.WriteLine($"What is the length of this snake: { hannahCobra.Length} inches long.");
            Console.WriteLine($"Where does this snake live:The {hannahCobra.TypeOfHabitat} where it is sandy and hot!");


        }
        
    }
}
