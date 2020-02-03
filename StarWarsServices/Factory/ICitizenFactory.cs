using System;
using System.Collections.Generic;
using System.Text;
using StarWarsModels.Citizens;

namespace StarWarsServices.Factory
{
    public interface ICitizenFactory
    {
       ICitizen CreateCitizen(string name, string planet);

    }
}
