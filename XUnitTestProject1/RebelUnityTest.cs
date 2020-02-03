
using StarWarsServices.Factory;
using Xunit;


namespace XUnitTestProject1
{

    public class RebelUnitTest
    {
        private readonly string TestName = "Name";
        private readonly string NoValidTestName = "No Valid Name";

        private readonly string TestPlanet = "Planet";
        private readonly string NoValidTestPlanet = "No Valid Planet";

       

        [Fact]
        public void CreateCitizenTest()
        {
            Assert.NotNull(RebelFactory.Instance.CreateCitizen(TestName, TestPlanet));
        }

        [Fact]
        public void CreateCitizenIncorrectNameTest()
        {
            bool x = false;
            try
            {
                var rebel = (RebelFactory.Instance.CreateCitizen(NoValidTestName, TestPlanet));
            }
            catch (CreationRebelException)
            {
                x = true;
            }
            Assert.True(x);
        }

        [Fact]
        public void CreateCitizenIncorrectPlanetTest()
        {
            bool x = false;
            try
            {
                var rebel = RebelFactory.Instance.CreateCitizen(TestName, NoValidTestPlanet);
            }
            catch (CreationRebelException)
            {
                x = true;
            }
            Assert.True(x);
        }

        [Fact]
        public void CreateCitizenIncorrectTest()
        {
            bool x = false;
            try
            {
                StarWarsModels.Citizens.ICitizen rebel = (RebelFactory.Instance.CreateCitizen(NoValidTestName, NoValidTestPlanet));
            }
            catch (CreationRebelException)
            {
                x = true;
            }
            Assert.True(x);
        }

        [Fact]
        public void CreateCitizenNameEmptyTest()
        {

            bool x = false;
            try
            {
                StarWarsModels.Citizens.ICitizen rebel = (RebelFactory.Instance.CreateCitizen(string.Empty, TestPlanet));
            }
            catch (CreationRebelException)
            {
                x = true;
            }
            Assert.True(x);
        }

        [Fact]
        public void CreateCitizenPlanetEmptyTest()
        {

            bool x = false;
            try
            {
                StarWarsModels.Citizens.ICitizen rebel = (RebelFactory.Instance.CreateCitizen(TestName, string.Empty));
            }
            catch (CreationRebelException)
            {
                x = true;
            }
            Assert.True(x);
        }

        [Fact]
        public void CreateCitizenEmptyTest()
        {

            bool x = false;
            try
            {
                StarWarsModels.Citizens.ICitizen rebel = (RebelFactory.Instance.CreateCitizen(string.Empty, string.Empty));
            }
            catch (CreationRebelException)
            {
                x = true;
            }
            Assert.True(x);
        }




    }
}
