using System;

namespace StarWarsCrossCutting.Exceptions
{
    [Serializable]
  public class CreationRebelException : Exception
  {
      
        public CreationRebelException(string message) : base(message)
        {
           
        }
       
    }
}