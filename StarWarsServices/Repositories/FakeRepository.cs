using System;
using System.Collections.Generic;
using System.Text;
using StarWarsModels.Citizens;

namespace StarWarsServices.Repositories
{
    class FakeRepository : IRepository
    {
        private readonly List<ICitizen> CitizenList = new List<ICitizen>
        {
            new Rebel()
            {
                Name = "J'ohn",
                Planet = "Mars"
            },
            new Rebel()
            {
            Name = "Kara",
            Planet = "Krypton"
            }
        };
           
        public List<ICitizen> ReadCitizens(string infoString)
        {
            return CitizenList;
        }
    }
}
