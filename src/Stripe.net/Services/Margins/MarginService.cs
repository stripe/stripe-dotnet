// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MarginService : Service<Margin>,
        ICreatable<Margin, MarginCreateOptions>,
        IListable<Margin, MarginListOptions>,
        IRetrievable<Margin, MarginGetOptions>,
        IUpdatable<Margin, MarginUpdateOptions>
    {
        public MarginService()
            : base(null)
        {
        }

        public MarginService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/billing/margins";

        public virtual Margin Create(MarginCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Margin>(HttpMethod.Post, $"/v1/billing/margins", options, requestOptions);
        }

        public virtual Task<Margin> CreateAsync(MarginCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Margin>(HttpMethod.Post, $"/v1/billing/margins", options, requestOptions, cancellationToken);
        }

        public virtual Margin Get(string id, MarginGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Margin>(HttpMethod.Get, $"/v1/billing/margins/{id}", options, requestOptions);
        }

        public virtual Task<Margin> GetAsync(string id, MarginGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Margin>(HttpMethod.Get, $"/v1/billing/margins/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Margin> List(MarginListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Margin>>(HttpMethod.Get, $"/v1/billing/margins", options, requestOptions);
        }

        public virtual Task<StripeList<Margin>> ListAsync(MarginListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Margin>>(HttpMethod.Get, $"/v1/billing/margins", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Margin> ListAutoPaging(MarginListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Margin>($"/v1/billing/margins", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Margin> ListAutoPagingAsync(MarginListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Margin>($"/v1/billing/margins", options, requestOptions, cancellationToken);
        }

        public virtual Margin Update(string id, MarginUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Margin>(HttpMethod.Post, $"/v1/billing/margins/{id}", options, requestOptions);
        }

        public virtual Task<Margin> UpdateAsync(string id, MarginUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Margin>(HttpMethod.Post, $"/v1/billing/margins/{id}", options, requestOptions, cancellationToken);
        }
    }
}
