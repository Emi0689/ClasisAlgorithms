using System;

namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton instance = null;
        protected Singleton() { } //Constructor

        public static Singleton Instance 
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}
