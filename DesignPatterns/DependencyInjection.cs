using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasClasicos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace ProgramasClasicos
    {

        public interface IBird
        {
            Egg Lay(Func<Chicken> createBird);
        }

        public class Chicken : IBird
        {
            public Chicken()
            {

            }

            public Egg Lay(Func<Chicken> createBird)
            {
                return new Egg(createBird);
            }
        }

        public class Egg
        {
            public Func<IBird> createBird;

            public Egg()
            {
            }

            public Egg(Func<IBird> createBird)
            {
                this.createBird = createBird;
            }

            public IBird Hatch()
            {
                var nuevoParajo = new Chicken();
                return nuevoParajo;
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                var chicken1 = new Chicken();
                var egg = chicken1.Lay(chicken1);
                var childChicken = egg.Hatch();
            }
        }
    }

}
