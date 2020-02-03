using System;
using System.Collections.Generic;
using System.Text;
using StarWarsModels.Citizens;
using StarWarsServices.Specification;

namespace StarWarsServices.Factory
{
    public class RebelFactory : ICitizenFactory
    {
        private readonly static RebelFactory _rebelFactoryInstance = new RebelFactory();
        

        private RebelFactory()
        {
        }


        public static RebelFactory Instance
        {
            get
            {

                return _rebelFactoryInstance;
            }
        }


        public ICitizen CreateCitizen(string name, string planet)
        {
            var n = new NameSpecification();
            if(n.IsSatisfiedBy(name) && n.IsSatisfiedBy(planet))
            {
                return new Rebel() { Name = name, Planet = planet, RegistrationionDate = DateTime.Today };
            }
            else
            {
                throw new CreationRebelException();
            }
        }
    }

        


    }

