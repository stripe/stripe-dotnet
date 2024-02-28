// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeService : Service<Dispute>,
        ICreatable<Dispute, DisputeCreateOptions>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute, DisputeGetOptions>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        public DisputeService()
            : base(null)
        {
        }

        public DisputeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/disputes";

        public virtual Dispute Create(DisputeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Post, $"/v1/issuing/disputes", options, requestOptions);
        }

        public virtual Task<Dispute> CreateAsync(DisputeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Post, $"/v1/issuing/disputes", options, requestOptions, cancellationToken);
        }

        public virtual Dispute Get(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Get, $"/v1/issuing/disputes/{id}", options, requestOptions);
        }

        public virtual Task<Dispute> GetAsync(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Get, $"/v1/issuing/disputes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Dispute> List(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Dispute>>(HttpMethod.Get, $"/v1/issuing/disputes", options, requestOptions);
        }

        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Dispute>>(HttpMethod.Get, $"/v1/issuing/disputes", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Dispute> ListAutoPaging(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Dispute>($"/v1/issuing/disputes", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Dispute> ListAutoPagingAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Dispute>($"/v1/issuing/disputes", options, requestOptions, cancellationToken);
        }

        public virtual Dispute Submit(string id, DisputeSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Post, $"/v1/issuing/disputes/{id}/submit", options, requestOptions);
        }

        public virtual Task<Dispute> SubmitAsync(string id, DisputeSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Post, $"/v1/issuing/disputes/{id}/submit", options, requestOptions, cancellationToken);
        }

        public virtual Dispute Update(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Post, $"/v1/issuing/disputes/{id}", options, requestOptions);
        }

        public virtual Task<Dispute> UpdateAsync(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Post, $"/v1/issuing/disputes/{id}", options, requestOptions, cancellationToken);
        }
    }
}
