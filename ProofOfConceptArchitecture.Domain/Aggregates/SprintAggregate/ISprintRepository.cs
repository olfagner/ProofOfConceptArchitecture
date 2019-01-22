using ProofOfConceptArchitecture.Domain.Infrastructure;

namespace ProofOfConceptArchitecture.Domain.Aggregates.SprintAggregate
{
    public interface ISprintRepository : IRepository<Sprint>
    {
        void AddItemBackLog(BackLogItem item);
    }
}
