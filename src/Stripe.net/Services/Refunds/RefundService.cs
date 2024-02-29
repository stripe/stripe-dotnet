// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RefundService : Service<Refund>,
        ICreatable<Refund, RefundCreateOptions>,
        IListable<Refund, RefundListOptions>,
        IRetrievable<Refund, RefundGetOptions>,
        IUpdatable<Refund, RefundUpdateOptions>
    {
        public RefundService()
            : base(null)
        {
        }

        public RefundService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/refunds";

        public virtual Refund Cancel(string id, RefundCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Post, $"/v1/refunds/{id}/cancel", options, requestOptions);
        }

        public virtual Task<Refund> CancelAsync(string id, RefundCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Post, $"/v1/refunds/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Refund Create(RefundCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Post, $"/v1/refunds", options, requestOptions);
        }

        public virtual Task<Refund> CreateAsync(RefundCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Post, $"/v1/refunds", options, requestOptions, cancellationToken);
        }

        public virtual Refund Get(string id, RefundGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Get, $"/v1/refunds/{id}", options, requestOptions);
        }

        public virtual Task<Refund> GetAsync(string id, RefundGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Get, $"/v1/refunds/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Refund> List(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Refund>>(HttpMethod.Get, $"/v1/refunds", options, requestOptions);
        }

        public virtual Task<StripeList<Refund>> ListAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Refund>>(HttpMethod.Get, $"/v1/refunds", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Refund> ListAutoPaging(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Refund>($"/v1/refunds", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Refund> ListAutoPagingAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Refund>($"/v1/refunds", options, requestOptions, cancellationToken);
        }

        public virtual Refund Update(string id, RefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Post, $"/v1/refunds/{id}", options, requestOptions);
        }

        public virtual Task<Refund> UpdateAsync(string id, RefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Post, $"/v1/refunds/{id}", options, requestOptions, cancellationToken);
        }
    }
}
