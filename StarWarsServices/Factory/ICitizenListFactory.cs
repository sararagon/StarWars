using System.Collections.Generic;
using StarWarsModels.Citizens;

namespace StarWarsServices.Factory
{
    public interface ICitizenListFactory
    {
        List<ICitizen> CreateCitizenList(string list);
    }
}
