using ProofOfConceptArchitecture.Domain.Aggregates.SprintAggregate;
using ProofOfConceptArchitecture.Domain.Events;
using ProofOfConceptArchitecture.Domain.Infrastructure;
using System;
using System.Collections.Generic;

namespace ProofOfConceptArchitecture.Domain.Aggregates.SprintAggregate
{
    public class Sprint : Entity, IAggregateRoot
    {
        private Guid _idSprint;
        private string _nameSprint;
        private DateTime _startDate;
        private DateTime _endDate;

        public Sprint(Guid idSprint, string nameSprint, DateTime startDate, DateTime endDate)
        {
            _idSprint = idSprint;
            _nameSprint = nameSprint;
            _startDate = startDate;
            _endDate = endDate;
        }

        private List<BackLogItem> _backLogItem;

        public IEnumerable<BackLogItem> BackLogItem => _backLogItem.AsReadOnly();

        public void AddBackLogItem(BackLogItem backLog)
        {
            // todo validations using fluent or bussines logic
            AddDomainEvent(new AddBackLogItemDomainEvent(this, backLog));
        }
    }
}
