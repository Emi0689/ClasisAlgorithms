using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IMediator
    {
        void Send(string message, IColleague colleague);
    }
}
