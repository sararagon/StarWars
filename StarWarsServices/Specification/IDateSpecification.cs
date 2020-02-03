using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsServices.Specification
{
    interface IDateSpecification
    {
        bool IsSatisfiedBy(DateTime d);
    }
}
