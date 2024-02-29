namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ServiceTest : BaseStripeTest
    {
        public ServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
        }

        [Fact]
        public void Get_ThrowsIfIdIsNull()
        {
            var client = new TestClient();
            var service = new TestService(client);

            Assert.Throws<ArgumentException>(() => service.Get(null));
        }

        [Fact]
        public void Get_ThrowsIfIdIsEmpty()
        {
            var client = new TestClient();
            var service = new TestService(client);

            Assert.Throws<ArgumentException>(() => service.Get(string.Empty));
        }

        [Fact]
        public void Get_ThrowsIfIdIsWhitespace()
        {
            var client = new TestClient();
            var service = new TestService(client);

            Assert.Throws<ArgumentException>(() => service.Get(" "));
        }

        [Fact]
        public void Search_ReturnsOnePage()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v1/test_entities/search",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""1""}, {""id"": ""2""}],""next_page"": ""page2"", ""has_more"": true, ""total_count"": 4}",
                query: "?query=my+query");

            var service = new TestService(this.StripeClient);

            HashSet<string> ids = new HashSet<string>();
            var searchResult = service.Search(new SearchOptions() { Query = "my query" });
            foreach (var testEntity in searchResult)
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Equal(2, ids.Count);
            Assert.Equal(4, searchResult.TotalCount);
        }

        [Fact]
        public void SearchAuto_ReturnsAllPages()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v1/test_entities/search",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""1""}, {""id"": ""2""}],""next_page"": ""page2"", ""has_more"": true}",
                query: "?query=my+query");

            this.StubRequest(
                HttpMethod.Get,
                "/v1/test_entities/search",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""3""}, {""id"": ""4""}],""next_page"": null, ""has_more"": false}",
                "?page=page2&query=my+query");

            var service = new TestService(this.StripeClient);

            HashSet<string> ids = new HashSet<string>();
            foreach (var testEntity in service.SearchAutoPaging(new SearchOptions() { Query = "my query" }))
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Equal(4, ids.Count);
            Assert.Equal(4, ids.Count);
        }

        [Fact]
        public async Task SearchAutoAsync_ReturnsAllPages()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v1/test_entities/search",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""1""}, {""id"": ""2""}],""next_page"": ""page2"", ""has_more"": true}",
                query: "?query=my+query");

            this.StubRequest(
                HttpMethod.Get,
                "/v1/test_entities/search",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""3""}, {""id"": ""4""}],""next_page"": null, ""has_more"": false}",
                "?page=page2&query=my+query");

            var service = new TestService(this.StripeClient);

            HashSet<string> ids = new HashSet<string>();
            await foreach (var testEntity in service.SearchAutoPagingAsync(new SearchOptions() { Query = "my query" }))
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Equal(4, ids.Count);
        }

        private class TestClient : IStripeClient
        {
            public string ApiBase { get; }

            public string ApiKey { get; }

            public string ClientId { get; }

            public string ConnectBase { get; }

            public string FilesBase { get; }

            public BaseOptions LastOptions { get; protected set; }

            public Task<T> RequestAsync<T>(
                HttpMethod method,
                string path,
                BaseOptions options,
                RequestOptions requestOptions,
                CancellationToken cancellationToken = default)
                where T : IStripeEntity
            {
                this.LastOptions = options;
                return Task.FromResult(default(T));
            }

            public Task<Stream> RequestStreamingAsync(
                HttpMethod method,
                string path,
                BaseOptions options,
                RequestOptions requestOptions,
                CancellationToken cancellationToken = default)
            {
                this.LastOptions = options;
                return Task.FromResult(Stream.Null);
            }
        }

        private class TestEntity : StripeEntity, IHasId
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }

        private class TestService : Service<TestEntity>,
            IListable<TestEntity, ListOptions>,
            IRetrievable<TestEntity, BaseOptions>,
            ISearchable<TestEntity, SearchOptions>
        {
            public TestService(IStripeClient client)
                : base(client)
            {
            }

            [Obsolete("This member is deprecated and will be removed in a future release")]
            public override string BasePath => "/v1/test_entities";

            public virtual TestEntity Get(string id, BaseOptions options = null, RequestOptions requestOptions = null)
            {
                return this.GetEntity(id, options, requestOptions);
            }

            public virtual Task<TestEntity> GetAsync(string id, BaseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
            }

            public virtual StripeList<TestEntity> List(ListOptions options = null, RequestOptions requestOptions = null)
            {
                return this.ListEntities(options, requestOptions);
            }

            public virtual Task<StripeList<TestEntity>> ListAsync(ListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
            }

            public virtual IEnumerable<TestEntity> ListAutoPaging(ListOptions options = null, RequestOptions requestOptions = null)
            {
                return this.ListEntitiesAutoPaging(options, requestOptions);
            }

            public virtual IAsyncEnumerable<TestEntity> ListAutoPagingAsync(ListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
            }

            public virtual StripeSearchResult<TestEntity> Search(SearchOptions options = null, RequestOptions requestOptions = null)
            {
                return this.Request<StripeSearchResult<TestEntity>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions);
            }

            public virtual Task<StripeSearchResult<TestEntity>> SearchAsync(SearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.RequestAsync<StripeSearchResult<TestEntity>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
            }

            public virtual IEnumerable<TestEntity> SearchAutoPaging(SearchOptions options = null, RequestOptions requestOptions = null)
            {
                return this.SearchRequestAutoPaging<TestEntity>($"{this.InstanceUrl("search")}", options, requestOptions);
            }

            public virtual IAsyncEnumerable<TestEntity> SearchAutoPagingAsync(SearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.SearchRequestAutoPagingAsync<TestEntity>($"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
            }
        }
    }
}
