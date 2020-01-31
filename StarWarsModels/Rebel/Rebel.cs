using System;

namespace StarWarsModels
{
    public class Rebel : ICitizen
    {
        public string Name { get; set; }
        public string Planet { get; set; }
        public DateTime RegistrationionDate { get; set; }

    }
}
