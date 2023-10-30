// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TestClockService : Service<TestClock>,
        ICreatable<TestClock, TestClockCreateOptions>,
        IDeletable<TestClock, TestClockDeleteOptions>,
        IListable<TestClock, TestClockListOptions>,
        IRetrievable<TestClock, TestClockGetOptions>
    {
        public TestClockService()
            : base(null)
        {
        }

        public TestClockService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/test_clocks";

        public virtual TestClock Advance(string id, TestClockAdvanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TestClock>(HttpMethod.Post, $"{this.InstanceUrl(id)}/advance", options, requestOptions);
        }

        public virtual Task<TestClock> AdvanceAsync(string id, TestClockAdvanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TestClock>(HttpMethod.Post, $"{this.InstanceUrl(id)}/advance", options, requestOptions, cancellationToken);
        }

        public virtual TestClock Create(TestClockCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<TestClock> CreateAsync(TestClockCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual TestClock Delete(string id, TestClockDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, options, requestOptions);
        }

        public virtual Task<TestClock> DeleteAsync(string id, TestClockDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual TestClock Get(string id, TestClockGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<TestClock> GetAsync(string id, TestClockGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TestClock> List(TestClockListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<TestClock>> ListAsync(TestClockListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TestClock> ListAutoPaging(TestClockListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<TestClock> ListAutoPagingAsync(TestClockListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
