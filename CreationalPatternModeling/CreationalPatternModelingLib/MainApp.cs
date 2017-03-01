using System;

namespace CreationalPatterns
{
    class MainApp
    {
        public static void Main()
        {
            //Create and run the African animal world.
            ContinentFactory africa = new AfricanFactory();
            AnimalKingdom world = new AnimalKingdom(africa);

            world.RunFoodChain();

            //Create and run the American anmal world.
            ContinentFactory america = new AmericaFactory();
            world = new AnimalKingdom(america);
            world.RunFoodChain();

            //wait for user input
            Console.ReadKey();

        }
    }
}
