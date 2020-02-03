using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsServices.Specification
{
    public interface IStringSpecification
    {
        bool IsSatisfiedBy(string s);
    }
}
