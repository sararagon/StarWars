namespace StarWarsServices.Specification
{
    public class NameSpecification : IStringSpecification
    {
        /// <summary>
        /// Check if the Name contains only a word.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsSatisfiedBy(string s)
        {
            return (s != null && s!= string.Empty && s.Split(' ').Length <= 1);
        }

    }
}
