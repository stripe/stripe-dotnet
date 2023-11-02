// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionService : Service<Subscription>,
        ICreatable<Subscription, SubscriptionCreateOptions>,
        IListable<Subscription, SubscriptionListOptions>,
        IRetrievable<Subscription, SubscriptionGetOptions>,
        ISearchable<Subscription, SubscriptionSearchOptions>,
        IUpdatable<Subscription, SubscriptionUpdateOptions>
    {
        public SubscriptionService()
            : base(null)
        {
        }

        public SubscriptionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/subscriptions";

        public virtual Subscription Cancel(string id, SubscriptionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(HttpMethod.Delete, $"/v1/subscriptions/{id}", options, requestOptions);
        }

        public virtual Task<Subscription> CancelAsync(string id, SubscriptionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(HttpMethod.Delete, $"/v1/subscriptions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Subscription Create(SubscriptionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(HttpMethod.Post, $"/v1/subscriptions", options, requestOptions);
        }

        public virtual Task<Subscription> CreateAsync(SubscriptionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(HttpMethod.Post, $"/v1/subscriptions", options, requestOptions, cancellationToken);
        }

        public virtual Subscription Get(string id, SubscriptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(HttpMethod.Get, $"/v1/subscriptions/{id}", options, requestOptions);
        }

        public virtual Task<Subscription> GetAsync(string id, SubscriptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(HttpMethod.Get, $"/v1/subscriptions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Subscription> List(SubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Subscription>>(HttpMethod.Get, $"/v1/subscriptions", options, requestOptions);
        }

        public virtual Task<StripeList<Subscription>> ListAsync(SubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Subscription>>(HttpMethod.Get, $"/v1/subscriptions", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Subscription> ListAutoPaging(SubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Subscription>($"/v1/subscriptions", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Subscription> ListAutoPagingAsync(SubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Subscription>($"/v1/subscriptions", options, requestOptions, cancellationToken);
        }

        public virtual Subscription Resume(string id, SubscriptionResumeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(HttpMethod.Post, $"/v1/subscriptions/{id}/resume", options, requestOptions);
        }

        public virtual Task<Subscription> ResumeAsync(string id, SubscriptionResumeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(HttpMethod.Post, $"/v1/subscriptions/{id}/resume", options, requestOptions, cancellationToken);
        }

        public virtual StripeSearchResult<Subscription> Search(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Subscription>>(HttpMethod.Get, $"/v1/subscriptions/search", options, requestOptions);
        }

        public virtual Task<StripeSearchResult<Subscription>> SearchAsync(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Subscription>>(HttpMethod.Get, $"/v1/subscriptions/search", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Subscription> SearchAutoPaging(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Subscription>($"/v1/subscriptions/search", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Subscription> SearchAutoPagingAsync(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Subscription>($"/v1/subscriptions/search", options, requestOptions, cancellationToken);
        }

        public virtual Subscription Update(string id, SubscriptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(HttpMethod.Post, $"/v1/subscriptions/{id}", options, requestOptions);
        }

        public virtual Task<Subscription> UpdateAsync(string id, SubscriptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(HttpMethod.Post, $"/v1/subscriptions/{id}", options, requestOptions, cancellationToken);
        }
    }
}
