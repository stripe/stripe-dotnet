namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class AutoPagingTest : BaseStripeTest
    {
        public AutoPagingTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
        }

        [Fact]
        public void ListAutoPaging()
        {
            // Set up stubbed requests
            var response1 = new HttpResponseMessage(HttpStatusCode.OK);
            response1.Content = new StringContent(GetResourceAsString("pageable_models.0.json"));
            var response2 = new HttpResponseMessage(HttpStatusCode.OK);
            response2.Content = new StringContent(GetResourceAsString("pageable_models.1.json"));
            var response3 = new HttpResponseMessage(HttpStatusCode.OK);
            response3.Content = new StringContent(GetResourceAsString("pageable_models.2.json"));

            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(response1))
                .Returns(Task.FromResult(response2))
                .Returns(Task.FromResult(response3))
                .Throws(new Exception("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService();
            var options = new ListOptions()
            {
                Limit = 2,
            };
            var models = service.ListAutoPaging(options).ToList();

            // Check results
            Assert.Equal(5, models.Count);
            Assert.Equal("pm_123", models[0].Id);
            Assert.Equal("pm_124", models[1].Id);
            Assert.Equal("pm_125", models[2].Id);
            Assert.Equal("pm_126", models[3].Id);
            Assert.Equal("pm_127", models[4].Id);

            // Check invocations
            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&starting_after=pm_124"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&starting_after=pm_126"),
                    ItExpr.IsAny<CancellationToken>());
        }

        public class PageableModel : StripeEntity<PageableModel>, IHasId
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }

        public class PageableService : Service<PageableModel>
        {
            public override string BasePath => "/pageablemodels";

            public IEnumerable<PageableModel> ListAutoPaging(ListOptions options)
            {
                return this.ListEntitiesAutoPaging(options, null);
            }
        }
    }
}
