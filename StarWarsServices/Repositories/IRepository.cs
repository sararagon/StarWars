using System.Collections.Generic;
using StarWarsModels.Citizens;


namespace StarWarsServices.Repositories
{
    public interface IRepository
    {
        List<ICitizen> ReadCitizens();
    }
}
