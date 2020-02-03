namespace StarWarsServices.Specification
{
    class NameSpecification : IStringSpecification
    {
        /// <summary>
        /// Check if the Name contains only a word.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsSatisfiedBy(string s)
        {
            return (s.Split(' ').Length <= 1);
        }

    }
}
