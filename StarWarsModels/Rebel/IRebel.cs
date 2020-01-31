using System;

namespace StarWarsModels
{
    public interface ICitizen
    {
        string Name { get; set; }
        string Planet { get; set; }
        DateTime RegistrationionDate { get; set; }
    }
}