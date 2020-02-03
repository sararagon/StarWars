using System;
using System.Collections.Generic;
using System.Text;
using StarWarsModels.Citizens;
using StarWarsServices.Specification;

namespace StarWarsServices.Factory
{
    public class RebelFactory : ICitizenFactory
    {
        private NameSpecification n;

        public RebelFactory(NameSpecification nS)
        {
            n = nS;
        }


        public ICitizen CreateCitizen(string name, string planet)
        {
            

            if (n.IsSatisfiedBy(name) && n.IsSatisfiedBy(planet))
            {
                return new Rebel() { Name = name, Planet = planet, RegistrationionDate = DateTime.Today};
            }
            else
            {
                throw new CreationRebelException();
            }
        }


    }
}
