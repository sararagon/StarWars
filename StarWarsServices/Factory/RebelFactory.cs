using StarWarsCrossCutting.Exceptions;
using StarWarsModels.Citizens;
using StarWarsServices.Specification;
using System;

namespace StarWarsServices.Factory
{
    public class RebelFactory : ICitizenFactory
    {

        private RebelFactory(IRebelSpecification r, IDateSpecification d)
        {
            _r = r;
            _d = d;
        }


        public RebelFactory()
        {
        }

        public static RebelFactory Instance { get; } = new RebelFactory();

        private readonly IRebelSpecification _r;
        private readonly IDateSpecification _d;
        


        public ICitizen CreateCitizen(string name, string planet)
        {
            
                var citizen = new Rebel() {Name = name, Planet = planet, RegistrationDate = DateTime.Today};
                if (_r.IsSatisfiedBy(citizen))
                {
                    return citizen;
                }
                else
                {
                    throw new CreationRebelException("Error al crear un Rebelde introduciendo parámetros.");
                }
            
        }

        public ICitizen CreateCitizen(ICitizen citizen)
        {
            if (_r.IsSatisfiedBy(citizen) && _d.IsSatisfiedBy(citizen.RegistrationDate))
            {
                return citizen;
            }
            else
            {
                throw new CreationRebelException("Error al crear un Rebelde desde su verificación.");
            }
        }

       
    }

        


    }

