using MediatR;
using ProofOfConceptArchitecture.Domain.Aggregates.SprintAggregate;

namespace ProofOfConceptArchitecture.Domain.Events
{
    public class AddBackLogItemDomainEvent : INotification
    {
        public Sprint Sprint { get; private set; }
        public BackLogItem BackLogItem { get; private set; }

        public AddBackLogItemDomainEvent(Sprint sprint, BackLogItem backLogItem)
        {
            Sprint = sprint;
            BackLogItem = backLogItem;
        }

    }
}
