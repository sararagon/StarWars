using System.Collections.Generic;
using StarWarsModels.Citizens;

namespace StarWarsServices.Factory
{
    interface ICitizenListFactory
    {
        List<ICitizen> CreateCitizenList(string list);
    }
}
