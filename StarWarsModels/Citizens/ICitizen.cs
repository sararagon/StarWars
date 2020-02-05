using System;

namespace StarWarsModels.Citizens
{
    public interface ICitizen
    {
        string Name { get; set; }
        string Planet { get; set; }
        DateTime RegistrationDate { get; set; }
    }
}