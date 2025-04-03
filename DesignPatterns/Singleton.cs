using System;

namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton instance = null; // propiedad
        protected Singleton() { } //Constructor no utilidazado

        public static Singleton Instance 
        {
            get
            {
                if (instance == null) // Pregunto si esta creado, sino lo creo
                    instance = new Singleton();

                return instance;
            }
        }

        //Para utilizar solo llamar a Singleton.Instance

    }
}
