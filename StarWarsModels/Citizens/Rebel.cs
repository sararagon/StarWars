using System;

namespace StarWarsModels.Citizens
{
    public class Rebel : ICitizen
    {
        public string Name { get; set; }
        public string Planet { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
