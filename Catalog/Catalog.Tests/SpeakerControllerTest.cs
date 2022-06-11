using Catalog.Web.API.Controllers;
using Catalog.Web.API.Models;
using Microsoft.AspNetCore.Mvc;
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
        public SpeakerControllerTest()
        {
            controller = new SpeakerController();
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
        [Fact]
        public void Given_Exact_Match_Then_One_Item_In_List()
        {
            var result = controller.Search("Türkay Ürkmez") as OkObjectResult;

            var speakers = ((IEnumerable<Speaker>)result.Value).ToList();


            Assert.IsType<List<Speaker>>(result.Value);            
            Assert.Single<Speaker>(speakers);
            Assert.Equal("Türkay Ürkmez", speakers[0].Name);        
         
            
        }

        [Theory]
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










    }
}