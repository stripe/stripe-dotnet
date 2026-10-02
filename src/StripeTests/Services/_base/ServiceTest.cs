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
    using STJS = System.Text.Json.Serialization;

    public class ServiceTest : BaseStripeTest
    {
        public ServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
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
            var options = new SearchOptions() { Query = "my query" };

            HashSet<string> ids = new HashSet<string>();
            foreach (var testEntity in service.SearchAutoPaging(options))
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Null(options.Page);

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

            var options = new SearchOptions() { Query = "my query" };
            HashSet<string> ids = new HashSet<string>();
            await foreach (var testEntity in service.SearchAutoPagingAsync(options))
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Null(options.Page);

            Assert.Equal(4, ids.Count);
        }

        [Fact]
        public void V2Pagination_ReturnsOnePage()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/test_entities",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""1""}, {""id"": ""2""}],""next_page_url"": null}",
                query: "?foo=bar");

            var service = new TestService(this.StripeClient);

            HashSet<string> ids = new HashSet<string>();
            var options = new BaseOptions();
            options.AddExtraParam("foo", "bar");
            var results = service.ListV2AutoPaging(options);
            foreach (var testEntity in results)
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Equal(2, ids.Count);
        }

        [Fact]
        public void V2Pagination_ReturnsAllPages()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/test_entities",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""1""}, {""id"": ""2""}],""next_page_url"": ""/v2/test_entities/page1""}",
                query: "?foo=bar");

            this.StubRequest(
                HttpMethod.Get,
                "/v2/test_entities/page1",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""3""}, {""id"": ""4""}],""next_page_url"": ""/v2/test_entities/page2""}");

            this.StubRequest(
                HttpMethod.Get,
                "/v2/test_entities/page2",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""5""}, {""id"": ""6""}],""next_page_url"": null}");

            var service = new TestService(this.StripeClient);

            HashSet<string> ids = new HashSet<string>();
            var options = new BaseOptions();
            options.AddExtraParam("foo", "bar");
            foreach (var testEntity in service.ListV2AutoPaging(options))
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Equal(6, ids.Count);
        }

        [Fact]
        public async Task V2PaginationAsync_ReturnsAllPages()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/test_entities",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""1""}, {""id"": ""2""}],""next_page_url"": ""/v2/test_entities/page1""}",
                query: "?foo=bar");

            this.StubRequest(
                HttpMethod.Get,
                "/v2/test_entities/page1",
                (HttpStatusCode)200,
                @"{""data"": [{""id"": ""3""}, {""id"": ""4""}],""next_page_url"": null}");

            var service = new TestService(this.StripeClient);

            HashSet<string> ids = new HashSet<string>();
            var options = new BaseOptions();
            options.AddExtraParam("foo", "bar");
            await foreach (var testEntity in service.ListV2AutoPagingAsync(options))
            {
                Assert.NotNull(testEntity);
                ids.Add(testEntity.Id);
            }

            Assert.Equal(4, ids.Count);
        }

        [Fact]
        public void V2SearchPagination_ReplaysPostAcrossEmptyPages()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/test_entities/search",
                (HttpStatusCode)200,
                @"{""object"":""v2.search_result"",""data"":[{""id"":""1""}],""next_page_url"":""/v2/test_entities/search?page=2"",""total_count"":2}",
                string.Empty);
            this.StubRequest(
                HttpMethod.Post,
                "/v2/test_entities/search",
                (HttpStatusCode)200,
                @"{""object"":""v2.search_result"",""data"":[],""next_page_url"":""/v2/test_entities/search?page=3"",""total_count"":2}",
                "?page=2");
            this.StubRequest(
                HttpMethod.Post,
                "/v2/test_entities/search",
                (HttpStatusCode)200,
                @"{""object"":""v2.search_result"",""data"":[{""id"":""2""}],""next_page_url"":null,""total_count"":2}",
                "?page=3");

            var options = new BaseOptions();
            options.AddExtraParam("query", "widgets");
            options.AddExtraParam("future", "value");
            var service = new TestService(this.StripeClient);
            var ids = new List<string>();
            foreach (var entity in service.SearchV2AutoPaging(options))
            {
                ids.Add(entity.Id);
            }

            Assert.Equal(new[] { "1", "2" }, ids);
            this.MockHttpClientFixture.AssertRequest(HttpMethod.Post, "/v2/test_entities/search");
            this.MockHttpClientFixture.AssertRequest(HttpMethod.Post, "/v2/test_entities/search", "?page=2");
            this.MockHttpClientFixture.AssertRequest(HttpMethod.Post, "/v2/test_entities/search", "?page=3");
        }

        [Fact]
        public async Task V2SearchPaginationAsync_ReplaysPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/test_entities/search",
                (HttpStatusCode)200,
                @"{""object"":""v2.search_result"",""data"":[{""id"":""1""}],""next_page_url"":null,""total_count"":1}",
                string.Empty);

            var ids = new List<string>();
            await foreach (var entity in new TestService(this.StripeClient).SearchV2AutoPagingAsync(new BaseOptions()))
            {
                ids.Add(entity.Id);
            }

            Assert.Equal(new[] { "1" }, ids);
        }

        private class TestClient : IStripeClient
        {
            public string ApiBase { get; }

            public string ApiKey { get; }

            public string ClientId { get; }

            public string ConnectBase { get; }

            public string FilesBase { get; }

            public string MeterEventsBase { get; }

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

            public Task<T> RequestAsync<T>(
                BaseAddress baseAddress,
                HttpMethod method,
                string path,
                BaseOptions options,
                RequestOptions requestOptions,
                ApiMode apiMode,
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
            [STJS.JsonPropertyName("id")]
            public string Id { get; set; }
        }

        private class TestService : Service<TestEntity>
        {
            public TestService(IStripeClient client)
                : base(client)
            {
            }

            public virtual TestEntity Get(string id, BaseOptions options = null, RequestOptions requestOptions = null)
            {
                return this.Request<TestEntity>(BaseAddress.Api, HttpMethod.Get, $"/v1/test_entities/{WebUtility.UrlEncode(id)}", options, requestOptions);
            }

            public virtual StripeSearchResult<TestEntity> Search(SearchOptions options = null, RequestOptions requestOptions = null)
            {
                return this.Request<StripeSearchResult<TestEntity>>(BaseAddress.Api, HttpMethod.Get, $"/v1/test_entities/search", options, requestOptions);
            }

            public virtual IEnumerable<TestEntity> SearchAutoPaging(SearchOptions options = null, RequestOptions requestOptions = null)
            {
                return this.SearchRequestAutoPaging<TestEntity>($"/v1/test_entities/search", options, requestOptions);
            }

            public virtual IAsyncEnumerable<TestEntity> SearchAutoPagingAsync(SearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.SearchRequestAutoPagingAsync<TestEntity>($"/v1/test_entities/search", options, requestOptions, cancellationToken);
            }

            public virtual IEnumerable<TestEntity> ListV2AutoPaging(BaseOptions options = null, RequestOptions requestOptions = null)
            {
                return this.ListRequestAutoPaging<TestEntity>($"/v2/test_entities", options, requestOptions);
            }

            public virtual IAsyncEnumerable<TestEntity> ListV2AutoPagingAsync(BaseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.ListRequestAutoPagingAsync<TestEntity>($"/v2/test_entities", options, requestOptions, cancellationToken);
            }

            public virtual IEnumerable<TestEntity> SearchV2AutoPaging(BaseOptions options = null, RequestOptions requestOptions = null)
            {
                return this.V2SearchRequestAutoPaging<TestEntity>($"/v2/test_entities/search", options, requestOptions);
            }

            public virtual IAsyncEnumerable<TestEntity> SearchV2AutoPagingAsync(BaseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
            {
                return this.V2SearchRequestAutoPagingAsync<TestEntity>($"/v2/test_entities/search", options, requestOptions, cancellationToken);
            }
        }
    }
}
