using System.Threading.Tasks;
using Core.Events;

namespace Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent evt);
    }

    public interface IEventHandler
    {
    }
}