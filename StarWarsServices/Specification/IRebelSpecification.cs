using StarWarsModels.Citizens;

namespace StarWarsServices.Specification
{
    public interface IRebelSpecification
    {
        bool IsSatisfiedBy(ICitizen citizen);
    }
}
