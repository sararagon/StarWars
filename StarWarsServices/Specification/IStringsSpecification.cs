using System;
using System.Collections.Generic;
using System.Text;
using StarWarsModels.Citizens;

namespace StarWarsServices.Specification
{
    public interface IStringsSpecification
    {
        bool IsSatisfiedBy(ICitizen citizen);
    }
}
