﻿using MicroRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent>: IEventHandler where TEvent: Event
    {
        Task Handle(Task @event);
    }

    public interface IEventHandler
    {

    }
}
