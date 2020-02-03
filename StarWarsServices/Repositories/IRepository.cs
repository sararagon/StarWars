using  System;
using System.Collections.Generic;
using System.Text;
using StarWarsModels.Citizens;


namespace StarWarsServices.Repositories
{
    interface IRepository
    {
        List<ICitizen> ReadCitizens(string infoString);
    }
}
