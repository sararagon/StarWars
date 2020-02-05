using StarWarsModels.Citizens;

namespace StarWarsServices.Factory
{
    public interface ICitizenFactory
    {
       ICitizen CreateCitizen(string name, string planet);
       ICitizen CreateCitizen(ICitizen citizen);

    }
}
