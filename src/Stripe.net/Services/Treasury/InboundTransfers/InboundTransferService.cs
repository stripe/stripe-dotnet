// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InboundTransferService : Service<InboundTransfer>,
        ICreatable<InboundTransfer, InboundTransferCreateOptions>,
        IListable<InboundTransfer, InboundTransferListOptions>,
        IRetrievable<InboundTransfer, InboundTransferGetOptions>
    {
        public InboundTransferService()
            : base(null)
        {
        }

        public InboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/inbound_transfers";

        public virtual InboundTransfer Cancel(string id, InboundTransferCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers/{id}/cancel", options, requestOptions);
        }

        public virtual Task<InboundTransfer> CancelAsync(string id, InboundTransferCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual InboundTransfer Create(InboundTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers", options, requestOptions);
        }

        public virtual Task<InboundTransfer> CreateAsync(InboundTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers", options, requestOptions, cancellationToken);
        }

        public virtual InboundTransfer Get(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransfer>(HttpMethod.Get, $"/v1/treasury/inbound_transfers/{id}", options, requestOptions);
        }

        public virtual Task<InboundTransfer> GetAsync(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransfer>(HttpMethod.Get, $"/v1/treasury/inbound_transfers/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InboundTransfer> List(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InboundTransfer>>(HttpMethod.Get, $"/v1/treasury/inbound_transfers", options, requestOptions);
        }

        public virtual Task<StripeList<InboundTransfer>> ListAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InboundTransfer>>(HttpMethod.Get, $"/v1/treasury/inbound_transfers", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InboundTransfer> ListAutoPaging(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InboundTransfer>($"/v1/treasury/inbound_transfers", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InboundTransfer> ListAutoPagingAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InboundTransfer>($"/v1/treasury/inbound_transfers", options, requestOptions, cancellationToken);
        }
    }
}
