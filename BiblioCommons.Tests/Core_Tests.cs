using BiblioCommons.Exceptions;
using BiblioCommons.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BiblioCommons.Tests
{
    [TestClass]
    public class Core_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(RestException))]
        public void BiblioCommonsRestClient_WhenApiReturnsAnError_RestExceptionThrown()
        {
            using (SimpleServer.Create(Response.RestResponse_NotFound_Handler, "RestErrorResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                client.GetLibrary("NonExistentLibraryId");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(MasheryException))]
        public void BiblioCommonsRestClient_WhenMasheryReturnsAnError_MasheryExceptionThrown()
        {
            using (SimpleServer.Create(Response.MasheryResponse_Handler, "MasheryErrorResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                client.GetLibrary();
            }
        }
    }
}
