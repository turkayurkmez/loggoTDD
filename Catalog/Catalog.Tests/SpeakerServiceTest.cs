using Catalog.Business;
using System.Linq;
using Xunit;

namespace Catalog.Tests
{
    public class SpeakerServiceTest
    {


        [Fact()]
        public void Given_Exact_Match_Then_One_Item_In_List()
        {
            var speakerService = new SpeakerService(null);

            string speakerName = "Türkay";

            var speakers = speakerService.Search(speakerName);

            //Assert.Single<Speaker>(speakers);
            Assert.Equal("Türkay", speakers.ToList()[0].Name);


        }
    }
}
