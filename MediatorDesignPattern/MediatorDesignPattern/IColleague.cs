using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public abstract class IColleague
    {
        private IMediator mediator;

        public IMediator Mediator
        {
            get;
        }

        public IColleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Communicate(string message)
        {
            this.mediator.Send(message,this);
        }

        public abstract void Receive(string message);
    }
}
