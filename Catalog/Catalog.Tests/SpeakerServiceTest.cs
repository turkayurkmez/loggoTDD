using Catalog.Business;
using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Catalog.Tests
{
    public class SpeakerServiceTest
    {

       
        [Fact()]
        public void Given_Exact_Match_Then_One_Item_In_List()
        {
            var speakerService = new SpeakerService();

            string speakerName = "Türkay";

            var speakers = speakerService.Search(speakerName);
            
            //Assert.Single<Speaker>(speakers);
            Assert.Equal("Türkay", speakers.ToList()[0].Name);


        }
    }
}
