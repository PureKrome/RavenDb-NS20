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
            IDocumentStore store = NewDocumentStore(noStaleQueries: true);
        }
    }
}