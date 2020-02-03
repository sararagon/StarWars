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

    }
}