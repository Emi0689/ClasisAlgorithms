using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class User : IColleague
    {
        public User(IMediator mediator) : base(mediator)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine("Un usuario recibe: " + message);
        }
    }
}
