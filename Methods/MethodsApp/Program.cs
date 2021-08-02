using System;

namespace MethodsApp
{
    class Program
    {

        // virtual = can be overridden
        // abstract = has no body
        // overRide = overRides the method
        // asynch = used for asynchronous programming
        // sealed = immutable


        static void Main(string[] args)
        {
            var result = DoThis(10, "Sad");
            var resultII = DoThis(25);

            var pizza1 = OrderPizza(true, pineapple: true, true);

            Console.WriteLine(pizza1);


            // tuple
            var myTuple = ("Joe", "Black", 25);

            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple.Item2);

            var myNamedTuple = (fName: "Jane", lName: "Doe", age: 34);

            Console.WriteLine($"my name is { myNamedTuple.fName} {myNamedTuple.lName}");

            var title = "The End is Nigh";
            int copies = 23;

            var myTupleII = (title, copies);

            Console.WriteLine(myTupleII);
            Console.WriteLine(myTupleII.title);

            var weight = ConvertPoundsToStones(15);
            Console.WriteLine(weight);
        }


        // tuple method
        public static (int stones, int pounds) ConvertPoundsToStones(int Pounds)
        {
            const int poundsInAStone = 14;
            var st = Pounds / poundsInAStone;
            var lbs = Pounds % poundsInAStone;
            return (st, lbs);

        }

        public static string OrderPizza(bool anchovies, bool pineapple, bool mushroom = false) 
        {
            var pizza = "Piazza with tomato sauce, cheese, ";

            if (anchovies) pizza += "anchovies, ";
            if (pineapple) pizza += "NO STOP IT, ";
            if (mushroom) pizza += "mushroom, ";

            return pizza;
            
        }

        public static int DoThis(int x, string y = "happy") 
        {
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }


        





    }

    
}
