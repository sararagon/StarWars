using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsServices.Specification
{
    interface IStringSpecification
    {
        bool IsSatisfiedBy(string s);
    }
}
