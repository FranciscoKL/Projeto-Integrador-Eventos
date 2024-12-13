using System.Runtime.Serialization;

namespace Events.Service.Exceptions
{
    [Serializable]
    internal class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string? message) : base(message)
        {

        }

    }
}