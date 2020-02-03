using System;
using System.Runtime.Serialization;

namespace StarWarsServices.Factory
{
    [Serializable]
  public class CreationRebelException : Exception
    {
        public CreationRebelException()
        {
        }

        public CreationRebelException(string message) : base(message)
        {
        }

        public CreationRebelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CreationRebelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}