using System;

namespace StarWarsServices.Specification
{
    class DateSpecification : IDateSpecification
    {
        /// <summary>
        /// Check if the date has passed or it's today.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public Boolean IsSatisfiedBy(DateTime d)
        {
            return (!(d != string.Empty) && DateTime.Compare(d, DateTime.Today) <= 0);
        }
    }
}
