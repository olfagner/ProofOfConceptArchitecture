using System;
using System.Collections.Generic;
using ProofOfConceptArchitecture.Domain.Infrastructure;


namespace ProofOfConceptArchitecture.Domain.Aggregates.SprintAggregate
{
    public class BackLogItem : ValueObject
    {
        public Guid IdBackLogItem { get; private set; }
        public String Name { get; private set; }
        public String Description { get; private set; }

        public BackLogItem(Guid idBackLogItem, string name, string description)
        {
            IdBackLogItem = idBackLogItem;
            Name = Name;
            Description = description;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return IdBackLogItem;
            yield return Name;
            yield return Description;
        }
    }
}
