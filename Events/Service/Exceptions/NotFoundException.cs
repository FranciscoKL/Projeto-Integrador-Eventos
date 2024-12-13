using System.Runtime.Serialization;

namespace Events.Service.Exceptions
{
    [Serializable]
    internal class NotFoundException : ApplicationException
    {
        public NotFoundException(string? message) : base(message)
        {

        }
    }
}