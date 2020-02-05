using StarWarsModels.Citizens;
using System.Collections.Generic;

namespace StarWarsServices.Repositories
{
    public class FakeRepository : IRepository
    {
        private readonly List<ICitizen> _citizenList = new List<ICitizen>
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
           
        public List<ICitizen> ReadCitizens()
        {
            return _citizenList;
        }
    }
}
