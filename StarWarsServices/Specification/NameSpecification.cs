using StarWarsModels.Citizens;

namespace StarWarsServices.Specification
{
    public class NameSpecification : IStringsSpecification
    {
        public bool IsSatisfiedBy(ICitizen citizen)
        {
            return (!string.IsNullOrEmpty(citizen.Name) && !string.IsNullOrEmpty(citizen.Planet));
        }

    }
}
