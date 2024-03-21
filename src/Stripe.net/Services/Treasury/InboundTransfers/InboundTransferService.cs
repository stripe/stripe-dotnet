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
        {
        }

        public InboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/inbound_transfers";

        /// <summary>
        /// <p>Cancels an InboundTransfer.</p>.
        /// </summary>
        public virtual InboundTransfer Cancel(string id, InboundTransferCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels an InboundTransfer.</p>.
        /// </summary>
        public virtual Task<InboundTransfer> CancelAsync(string id, InboundTransferCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates an InboundTransfer.</p>.
        /// </summary>
        public virtual InboundTransfer Create(InboundTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an InboundTransfer.</p>.
        /// </summary>
        public virtual Task<InboundTransfer> CreateAsync(InboundTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransfer>(HttpMethod.Post, $"/v1/treasury/inbound_transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing InboundTransfer.</p>.
        /// </summary>
        public virtual InboundTransfer Get(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransfer>(HttpMethod.Get, $"/v1/treasury/inbound_transfers/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing InboundTransfer.</p>.
        /// </summary>
        public virtual Task<InboundTransfer> GetAsync(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransfer>(HttpMethod.Get, $"/v1/treasury/inbound_transfers/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of InboundTransfers sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual StripeList<InboundTransfer> List(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InboundTransfer>>(HttpMethod.Get, $"/v1/treasury/inbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of InboundTransfers sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual Task<StripeList<InboundTransfer>> ListAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InboundTransfer>>(HttpMethod.Get, $"/v1/treasury/inbound_transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of InboundTransfers sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual IEnumerable<InboundTransfer> ListAutoPaging(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InboundTransfer>($"/v1/treasury/inbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of InboundTransfers sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InboundTransfer> ListAutoPagingAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InboundTransfer>($"/v1/treasury/inbound_transfers", options, requestOptions, cancellationToken);
        }
    }
}
