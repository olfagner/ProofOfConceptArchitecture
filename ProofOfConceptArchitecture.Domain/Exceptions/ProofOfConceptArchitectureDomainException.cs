using System;
using System.Collections.Generic;
using System.Text;

namespace ProofOfConceptArchitecture.Domain.Exceptions
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class ProofOfConceptArchitectureDomainException : Exception
    {
        public ProofOfConceptArchitectureDomainException()
        { }

        public ProofOfConceptArchitectureDomainException(string message)
            : base(message)
        { }

        public ProofOfConceptArchitectureDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
