namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ServiceTest : BaseStripeTest
    {
        [Fact]
        public void Get_ExpandProperties()
        {
            var client = new TestClient();
            var service = new TestService { Client = client };

            service.ExpandSimple = true;
            service.ExpandMultiWordProperty = true;
            service.Get("foo");

            Assert.Contains("simple", client.LastOptions.Expand);
            Assert.Contains("multi_word_property", client.LastOptions.Expand);
        }

        [Fact]
        public void List_ExpandProperties()
        {
            var client = new TestClient();
            var service = new TestService { Client = client };

            service.ExpandSimple = true;
            service.ExpandMultiWordProperty = true;
            service.List();

            Assert.Contains("data.simple", client.LastOptions.Expand);
            Assert.Contains("data.multi_word_property", client.LastOptions.Expand);
        }

        private class TestClient : IStripeClient
        {
            public BaseOptions LastOptions { get; protected set; }

            public Task<T> RequestAsync<T>(
                HttpMethod method,
                string path,
                BaseOptions options,
                RequestOptions requestOptions,
                CancellationToken cancellationToken = default(CancellationToken))
                where T : IStripeEntity
            {
                this.LastOptions = options;
                return Task.FromResult(default(T));
            }
        }

        private class TestEntity : StripeEntity, IHasId
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }

        private class TestService : Service<TestEntity>,
            IListable<TestEntity, ListOptions>,
            IRetrievable<TestEntity>
        {
            public override string BasePath => "/v1/test_entities";

            public bool ExpandSimple { get; set; }

            public bool ExpandMultiWordProperty { get; set; }

            public virtual TestEntity Get(string id, RequestOptions requestOptions = null)
            {
                return this.GetEntity(id, null, requestOptions);
            }

            public virtual Task<TestEntity> GetAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return this.GetEntityAsync(id, null, requestOptions, cancellationToken);
            }

            public virtual StripeList<TestEntity> List(ListOptions options = null, RequestOptions requestOptions = null)
            {
                return this.ListEntities(options, requestOptions);
            }

            public virtual Task<StripeList<TestEntity>> ListAsync(ListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
            }

            public virtual IEnumerable<TestEntity> ListAutoPaging(ListOptions options = null, RequestOptions requestOptions = null)
            {
                return this.ListEntitiesAutoPaging(options, requestOptions);
            }
        }
    }
}
