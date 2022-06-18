using Catalog.Business;
using Catalog.Entity;
using Catalog.Web.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Catalog.Tests
{
    public class SpeakerControllerTest
    {
        //[Fact]
        //public void ItExists()
        //{
        //    /*
        //     * Ben bir konferans organizatörü olarak
        //     * Konuşmacı aramak istiyorum
        //     * Böylelikle onlarla iletişim kurabilirim.
        //     */
        //    var controller = new Catalog.Web.API.Controllers.SpeakerController();

        //}

        //public void ItHasSearch()
        //{
        //    var controller = new Catalog.Web.API.Controllers.SpeakerController();
        //    var speaker =  controller.Search("Tur");

        //}


        readonly SpeakerController controller;
        private static Mock<ISpeakerService> speakerServiceMock;
        public SpeakerControllerTest()
        {
            Speaker speaker = new Speaker { Name = "Türkay Ürkmez" };

            speakerServiceMock = new Mock<ISpeakerService>();
            //çağrıldığında; speaker objesini döndüren bir nesne olsun.
            speakerServiceMock.Setup(x => x.Search(It.IsAny<string>()))
                              .Returns(() => new List<Speaker> { speaker });

            controller = new SpeakerController(new FakeSpeakerService());





            //MOCK: Anlamı, çorap kukla.... Mock library kullanarak; FakeDependency gibi nesneleri var edebiirsiniz! 

        }


        [Fact]
        public void It_Return_Ok_Object_Result()
        {
            var result = controller.Search("Tur");
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void It_Return_Collection_of_Speakers_Result()
        {

            var result = controller.Search("Tur") as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.IsType<List<Speaker>>(result.Value);
        }
        [Fact(Skip = "SpeakerServiceTest sınıfına taşındı")]
        public void Given_Exact_Match_Then_One_Item_In_List()
        {
            var result = controller.Search("Türkay") as OkObjectResult;

            var speakers = ((IEnumerable<Speaker>)result.Value).ToList();


            Assert.IsType<List<Speaker>>(result.Value);
            Assert.Single<Speaker>(speakers);
            Assert.Equal("Türkay", speakers[0].Name);


        }

        [Theory(Skip = "Fake data içerisinde, Türkay değeri kaldırıldı")]
        [InlineData("tÜrkay ürkmez")]
        [InlineData("Türkay ÜRKMEZ")]
      
        public void Given_InSensitive_Match_Then_One_Item_In_List(string name)
        {

        }
        [Fact]
        public void Given_No_Match_Return_Empty()
        {

        }

        [Theory]
        [InlineData("T")]
        [InlineData("t")]
        public void Given_Contain_Match_Then_One_Item_In_List(string name)
        {

        }

        [Fact]
        public void ItAcceptInterface()
        {
            ISpeakerService testSpeakerService = new FakeSpeakerService();

            //Act:
            var controller = new SpeakerController(testSpeakerService);
            
            Assert.NotNull(controller);
        }

        [Fact]
        public void Given_Search_String_Then_Speaker_Sevice_Searcch_Called_With_String()
        {
            var search = "Mu";
            controller.Search(search);
            speakerServiceMock.Verify(x => x.Search(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void Given_Speaker_Service_Then_Result_Is_Returned()
        {
           
            var result = controller.Search("Türkay") as OkObjectResult;
            Assert.NotNull(result);
            var speakers = ((IEnumerable<Speaker>)result.Value).ToList();


            
            Assert.Single<Speaker>(speakers);
        }
        















    }
}