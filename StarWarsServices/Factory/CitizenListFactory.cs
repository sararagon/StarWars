using StarWarsModels.Citizens;
using System.Collections.Generic;

namespace StarWarsServices.Factory
{
    public class CitizenListFactory : ICitizenListFactory
    {
        private readonly List<ICitizen> _listCitizen;
        private readonly ICitizenFactory _citizenFactory;

        public CitizenListFactory(List<ICitizen> listCitizen, ICitizenFactory citizenFactory)
        {
            _listCitizen = listCitizen;
            _citizenFactory = citizenFactory;
        }

        public List<ICitizen> CreateCitizenList(string list)
        {
            var split = list.Split(',');
            var x = 0;
            for (var i = 0; i < split.Length; i += 2)
            {

                _listCitizen[x] = _citizenFactory.CreateCitizen(split[i], split[i + 1]);
                x++;

            }

            return _listCitizen;

        }

        public List<ICitizen> CreateCitizenList(List<ICitizen> list)
        {
            var x = 0;
            foreach (var citizen in list)
            {
               _listCitizen[x] = _citizenFactory.CreateCitizen(citizen);
               x++;
            }

            return _listCitizen;
        }
    }
}
