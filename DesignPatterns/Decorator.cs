using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    // The base ComponentDecorator interface defines operations that can be altered by
    // decorators.
    public abstract class ComponentDecorator
    {
        public abstract string Operation();
    }

    // Concrete ComponentDecorators provide default implementations of the operations.
    // There might be several variations of these classes.
    class ConcreteComponentDecorator : ComponentDecorator
    {
        public override string Operation()
        {
            return "ConcreteComponentDecorator";
        }
    }

    // The base Decorator class follows the same interface as the other
    // ComponentDecorators. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped ComponentDecorator and
    // the means to initialize it.
    abstract class Decorator : ComponentDecorator
    {
        protected ComponentDecorator _ComponentDecorator;

        public Decorator(ComponentDecorator ComponentDecorator)
        {
            this._ComponentDecorator = ComponentDecorator;
        }

        public void SetComponentDecorator(ComponentDecorator ComponentDecorator)
        {
            this._ComponentDecorator = ComponentDecorator;
        }

        // The Decorator delegates all work to the wrapped ComponentDecorator.
        public override string Operation()
        {
            if (this._ComponentDecorator != null)
            {
                return this._ComponentDecorator.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(ComponentDecorator comp) : base(comp)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }

    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(ComponentDecorator comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }

    public class ClientDecorator
    {
        // The ClientDecorator code works with all objects using the ComponentDecorator interface.
        // This way it can stay independent of the concrete classes of
        // ComponentDecorators it works with.
        public void ClientDecoratorCode(ComponentDecorator ComponentDecorator)
        {
            Console.WriteLine("RESULT: " + ComponentDecorator.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClientDecorator ClientDecorator = new ClientDecorator();

            var simple = new ConcreteComponentDecorator();
            Console.WriteLine("ClientDecorator: I get a simple ComponentDecorator:");
            ClientDecorator.ClientDecoratorCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple ComponentDecorators but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("ClientDecorator: Now I've got a decorated ComponentDecorator:");
            ClientDecorator.ClientDecoratorCode(decorator2);
        }
    }
}
