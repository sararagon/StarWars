using System;

namespace StarWarsServices.Specification
{
    interface IDateSpecification
    {
        bool IsSatisfiedBy(DateTime d);
    }
}
