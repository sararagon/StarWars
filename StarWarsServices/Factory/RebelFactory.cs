using StarWarsModels.Citizens;
using StarWarsServices.Specification;
using System;

namespace StarWarsServices.Factory
{
    public class RebelFactory : ICitizenFactory
    {
        private RebelFactory()
        {
        }


        public static RebelFactory Instance { get; } = new RebelFactory();


        public ICitizen CreateCitizen(string name, string planet)
        {
            IStringsSpecification n = new NameSpecification();
            var citizen = new Rebel() { Name = name, Planet = planet, RegistrationionDate = DateTime.Today };
            if (n.IsSatisfiedBy(citizen))
            {
                return citizen;
            }
            else
            {
                throw new CreationRebelException();
            }
        }

       
    }

        


    }

