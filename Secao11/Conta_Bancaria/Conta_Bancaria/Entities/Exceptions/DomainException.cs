using System;


namespace Conta_Bancaria.Entities.Exceptions
{
    class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
