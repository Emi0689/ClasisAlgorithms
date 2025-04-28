using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasClasicos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Reflection;

    namespace ProgramasClasicos
    {
        //Statement:

        //Model the behavior of a system where:

        //A Bird(IBird) can lay an Egg(Egg).
        //An Egg can incubate(Hatch) to create a new Bird(IBird).
        //The creation of the new bird must be configurable, so that it is not directly coupled to a specific type of bird(Chicken).

        //Implement:

        //An IBird interface with a Lay method that receives a Func<IBird> function to define how to create the bird that will hatch from the egg.
        //A Chicken class that implements IBird.
        //An Egg class that stores a Func<IBird> function and can create the bird when its Hatch method is invoked.

        //Restrictions:

        //Egg must not instantiate the bird directly(new Chicken()), but use the Func<IBird> function provided to it.
        //The design must be flexible to allow other IBird types besides Chicken to exist in the future.

        //Objective:
        //Decouple the creation of the birds from the egg logic, using the Factory Method design pattern.

        public interface IBird
        {
            Egg Lay(Func<IBird> createBird);
        }

        public class Chicken : IBird
        {
            public Egg Lay(Func<IBird> createBird)
            {
                return new Egg(createBird);
            }
        }

        public class Egg
        {
            private readonly Func<IBird> createBird;

            public Egg(Func<IBird> createBird)
            {
                this.createBird = createBird ?? throw new ArgumentNullException(nameof(createBird));
            }

            public IBird Hatch()
            {
                return createBird();
            }
        }

        class ProgramFactory2
        {
            static void Main(string[] args)
            {
                // Creation of Chicken
                IBird motherChicken = new Chicken();

                // the Chicken lay a egg
                Egg egg = motherChicken.Lay(() => new Chicken());

                Console.WriteLine("Un huevo fue puesto.");

                // Now we Hatch the Egg
                IBird babyChicken = egg.Hatch();

                Console.WriteLine("¡Un nuevo pollito ha nacido!");

                // We check it
                Console.WriteLine($"El nuevo pájaro es un {babyChicken.GetType().Name}.");
            }
        }
    }

}
