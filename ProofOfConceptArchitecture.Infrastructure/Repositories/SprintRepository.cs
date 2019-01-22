using ProofOfConceptArchitecture.Domain.Aggregates.SprintAggregate;
using ProofOfConceptArchitecture.Domain.Infrastructure;

namespace ProofOfConceptArchitecture.Repositories
{
    public class SprintRepository : ISprintRepository
    {
        public IUnitOfWork UnitOfWork => throw new System.NotImplementedException();

        public void AddItemBackLog(BackLogItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}
