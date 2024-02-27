// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundTransferService : Service<OutboundTransfer>,
        ICreatable<OutboundTransfer, OutboundTransferCreateOptions>,
        IListable<OutboundTransfer, OutboundTransferListOptions>,
        IRetrievable<OutboundTransfer, OutboundTransferGetOptions>
    {
        public OutboundTransferService()
            : base(null)
        {
        }

        public OutboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/outbound_transfers";

        public virtual OutboundTransfer Cancel(string id, OutboundTransferCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundTransfer>(HttpMethod.Post, $"/v1/treasury/outbound_transfers/{id}/cancel", options, requestOptions);
        }

        public virtual Task<OutboundTransfer> CancelAsync(string id, OutboundTransferCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundTransfer>(HttpMethod.Post, $"/v1/treasury/outbound_transfers/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual OutboundTransfer Create(OutboundTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundTransfer>(HttpMethod.Post, $"/v1/treasury/outbound_transfers", options, requestOptions);
        }

        public virtual Task<OutboundTransfer> CreateAsync(OutboundTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundTransfer>(HttpMethod.Post, $"/v1/treasury/outbound_transfers", options, requestOptions, cancellationToken);
        }

        public virtual OutboundTransfer Get(string id, OutboundTransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundTransfer>(HttpMethod.Get, $"/v1/treasury/outbound_transfers/{id}", options, requestOptions);
        }

        public virtual Task<OutboundTransfer> GetAsync(string id, OutboundTransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundTransfer>(HttpMethod.Get, $"/v1/treasury/outbound_transfers/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<OutboundTransfer> List(OutboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<OutboundTransfer>>(HttpMethod.Get, $"/v1/treasury/outbound_transfers", options, requestOptions);
        }

        public virtual Task<StripeList<OutboundTransfer>> ListAsync(OutboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<OutboundTransfer>>(HttpMethod.Get, $"/v1/treasury/outbound_transfers", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<OutboundTransfer> ListAutoPaging(OutboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<OutboundTransfer>($"/v1/treasury/outbound_transfers", options, requestOptions);
        }

        public virtual IAsyncEnumerable<OutboundTransfer> ListAutoPagingAsync(OutboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<OutboundTransfer>($"/v1/treasury/outbound_transfers", options, requestOptions, cancellationToken);
        }
    }
}
