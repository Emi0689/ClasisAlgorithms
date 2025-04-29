using DesignPatterns.FactoryMethod1;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator2
{
    // El patrón Decorator permite agregar funcionalidades a un objeto de manera dinámica, sin alterar su estructura original.
    // Envuelve el objeto real dentro de un "decorador" que puede agregar (o modificar) comportamientos.
    // Ideal para evitar una explosión de subclases (combinaciones de funcionalidades).

    // Componente base
    public interface ICoffee
    {
        string GetDescription();
        decimal GetCost();
    }

    // Componente concreto
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Café simple";
        }

        public decimal GetCost()
        {
            return 5.0m;
        }
    }

    // Decorador base
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public virtual decimal GetCost()
        {
            return _coffee.GetCost();
        }
    }

    // Decorador de leche
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", leche";
        }

        public override decimal GetCost()
        {
            return _coffee.GetCost() + 1.5m;
        }
    }

    // Decorador de azúcar
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", azúcar";
        }

        public override decimal GetCost()
        {
            return _coffee.GetCost() + 0.5m;
        }
    }

    class ProgramDecorator1
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");
        }
    }
}
