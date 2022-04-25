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
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var options = new ListOptions
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

        [Fact]
        public void ListAutoPaging_NoParams()
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
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var models = service.ListAutoPaging().ToList();

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
                        m.RequestUri.Query == string.Empty),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?starting_after=pm_124"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?starting_after=pm_126"),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public void ListAutoPaging_StartingAfter()
        {
            // Set up stubbed requests
            var response1 = new HttpResponseMessage(HttpStatusCode.OK);
            response1.Content = new StringContent(GetResourceAsString("pageable_models.1.json"));
            var response2 = new HttpResponseMessage(HttpStatusCode.OK);
            response2.Content = new StringContent(GetResourceAsString("pageable_models.2.json"));

            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(response1))
                .Returns(Task.FromResult(response2))
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var options = new ListOptions
            {
                Limit = 2,
                StartingAfter = "pm_124",
            };
            var models = service.ListAutoPaging(options).ToList();

            // Check results
            Assert.Equal(3, models.Count);
            Assert.Equal("pm_125", models[0].Id);
            Assert.Equal("pm_126", models[1].Id);
            Assert.Equal("pm_127", models[2].Id);

            // Check invocations
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

        [Fact]
        public void ListAutoPaging_EndingBefore()
        {
            // Set up stubbed requests
            var response1 = new HttpResponseMessage(HttpStatusCode.OK);
            response1.Content = new StringContent(GetResourceAsString("pageable_models.1.json"));
            var response2 = new HttpResponseMessage(HttpStatusCode.OK);
            response2.Content = new StringContent(GetResourceAsString("pageable_models.0.json"));
            var response3 = new HttpResponseMessage(HttpStatusCode.OK);
            response3.Content = new StringContent(GetResourceAsString("pageable_models.0b.json"));

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
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var options = new ListOptions
            {
                Limit = 2,
                EndingBefore = "pm_127",
            };
            var models = service.ListAutoPaging(options).ToList();

            // Check results
            Assert.Equal(5, models.Count);
            Assert.Equal("pm_126", models[0].Id);
            Assert.Equal("pm_125", models[1].Id);
            Assert.Equal("pm_124", models[2].Id);
            Assert.Equal("pm_123", models[3].Id);
            Assert.Equal("pm_122", models[4].Id);

            // Check invocations
            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&ending_before=pm_127"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&ending_before=pm_125"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&ending_before=pm_123"),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public async Task ListAutoPagingAsync()
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
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var options = new ListOptions
            {
                Limit = 2,
            };
            var models = await service.ListAutoPagingAsync(options).ToListAsync();

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

        [Fact]
        public async Task ListAutoPagingAsync_NoParams()
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
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var models = await service.ListAutoPagingAsync().ToListAsync();

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
                        m.RequestUri.Query == string.Empty),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?starting_after=pm_124"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?starting_after=pm_126"),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public async Task ListAutoPagingAsync_StartingAfter()
        {
            // Set up stubbed requests
            var response1 = new HttpResponseMessage(HttpStatusCode.OK);
            response1.Content = new StringContent(GetResourceAsString("pageable_models.1.json"));
            var response2 = new HttpResponseMessage(HttpStatusCode.OK);
            response2.Content = new StringContent(GetResourceAsString("pageable_models.2.json"));

            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(response1))
                .Returns(Task.FromResult(response2))
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var options = new ListOptions
            {
                Limit = 2,
                StartingAfter = "pm_124",
            };
            var models = await service.ListAutoPagingAsync(options).ToListAsync();

            // Check results
            Assert.Equal(3, models.Count);
            Assert.Equal("pm_125", models[0].Id);
            Assert.Equal("pm_126", models[1].Id);
            Assert.Equal("pm_127", models[2].Id);

            // Check invocations
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

        [Fact]
        public async Task ListAutoPagingAsync_EndingBefore()
        {
            // Set up stubbed requests
            var response1 = new HttpResponseMessage(HttpStatusCode.OK);
            response1.Content = new StringContent(GetResourceAsString("pageable_models.1.json"));
            var response2 = new HttpResponseMessage(HttpStatusCode.OK);
            response2.Content = new StringContent(GetResourceAsString("pageable_models.0.json"));
            var response3 = new HttpResponseMessage(HttpStatusCode.OK);
            response3.Content = new StringContent(GetResourceAsString("pageable_models.0b.json"));

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
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var options = new ListOptions
            {
                Limit = 2,
                EndingBefore = "pm_127",
            };
            var models = await service.ListAutoPagingAsync(options).ToListAsync();

            // Check results
            Assert.Equal(5, models.Count);
            Assert.Equal("pm_126", models[0].Id);
            Assert.Equal("pm_125", models[1].Id);
            Assert.Equal("pm_124", models[2].Id);
            Assert.Equal("pm_123", models[3].Id);
            Assert.Equal("pm_122", models[4].Id);

            // Check invocations
            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&ending_before=pm_127"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&ending_before=pm_125"),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels" &&
                        m.RequestUri.Query == "?limit=2&ending_before=pm_123"),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public async Task ListAutoPagingAsync_WithCancellation()
        {
            // Set up stubbed requests
            var response1 = new HttpResponseMessage(HttpStatusCode.OK);
            response1.Content = new StringContent(GetResourceAsString("pageable_models.0.json"));
            var response2 = new HttpResponseMessage(HttpStatusCode.OK);
            response2.Content = new StringContent(GetResourceAsString("pageable_models.1.json"));

            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath == "/v1/pageablemodels"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(response1))
                .Returns(Task.FromResult(response2))
                .Throws(new StripeTestException("Unexpected invocation!"));

            // Call auto-paging method
            var service = new PageableService(this.StripeClient);
            var options = new ListOptions
            {
                Limit = 2,
            };
            var models = new List<PageableModel>();

            var source = new CancellationTokenSource();

            try
            {
                await foreach (var model in service.ListAutoPagingAsync(options).WithCancellation(source.Token))
                {
                    models.Add(model);

                    // Cancel in the middle of the second page
                    if (model.Id == "pm_125")
                    {
                        source.Cancel();
                    }
                }

                Assert.True(false, "Exception OperationCanceledException to be thrown");
            }
            catch (OperationCanceledException)
            {
            }
            finally
            {
                source.Dispose();
            }

            // Check results
            Assert.Equal(3, models.Count);
            Assert.Equal("pm_123", models[0].Id);
            Assert.Equal("pm_124", models[1].Id);
            Assert.Equal("pm_125", models[2].Id);

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
        }

        public class PageableModel : StripeEntity<PageableModel>, IHasId
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }

        public class PageableService : Service<PageableModel>
        {
            public PageableService(IStripeClient client)
                : base(client)
            {
            }

            public override string BasePath => "/v1/pageablemodels";

            public IEnumerable<PageableModel> ListAutoPaging(ListOptions options = null, RequestOptions requestOptions = null)
            {
                return this.ListEntitiesAutoPaging(options, requestOptions);
            }

            public IAsyncEnumerable<PageableModel> ListAutoPagingAsync(ListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
            }
        }
    }
}
