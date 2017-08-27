using Raven.Client;
using Raven.Tests.Helpers;
using Xunit;

namespace RavenDbSample.Tests
{
    public class UnitTest1 : RavenTestBase
    {
        [Fact]
        public void Test1()
        {
            // Ok - we've not setup the Store/Session for this test. Lets do it...
            IDocumentStore store = NewDocumentStore(noStaleQueries: true);
        }
    }
}