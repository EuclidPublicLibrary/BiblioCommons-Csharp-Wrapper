using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using BiblioCommons.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BiblioCommons.Tests
{
    [TestClass]
    public class Core_Titles_Tests
    {
        [TestMethod]
        public void SearchTitles_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "SearchTitlesSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.SearchTitles("Star Wars");

                // Assert
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.titles);
                Assert.AreEqual("6107584048", result.titles.First().id);
                Assert.IsNull(result.metadata);
            }
        }


        [TestMethod]
        public void GetTitle_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetTitleSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetTitle("6107584048");

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual("6107584048", result.id);
            }
        }


        [TestMethod]
        public void GetCopies_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetCopiesSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetCopies("6107584048");

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(58, result.copies.Count);
            }
        }
    }
}
