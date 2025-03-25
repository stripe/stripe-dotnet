// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InboundTransferService : Service
    {
        internal InboundTransferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal InboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// InboundTransfers APIs are used to create, retrieve or list InboundTransfers.
        /// </summary>
        public virtual V2.InboundTransfer Create(InboundTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/inbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// InboundTransfers APIs are used to create, retrieve or list InboundTransfers.
        /// </summary>
        public virtual Task<V2.InboundTransfer> CreateAsync(InboundTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/inbound_transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve an InboundTransfer by ID.
        /// </summary>
        public virtual V2.InboundTransfer Get(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.InboundTransfer>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve an InboundTransfer by ID.
        /// </summary>
        public virtual Task<V2.InboundTransfer> GetAsync(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.InboundTransfer>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of InboundTransfers.
        /// </summary>
        public virtual V2.StripeList<V2.InboundTransfer> List(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.InboundTransfer>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of InboundTransfers.
        /// </summary>
        public virtual Task<V2.StripeList<V2.InboundTransfer>> ListAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.InboundTransfer>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of InboundTransfers.
        /// </summary>
        public virtual IEnumerable<V2.InboundTransfer> ListAutoPaging(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.InboundTransfer>($"/v2/money_management/inbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of InboundTransfers.
        /// </summary>
        public virtual IAsyncEnumerable<V2.InboundTransfer> ListAutoPagingAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.InboundTransfer>($"/v2/money_management/inbound_transfers", options, requestOptions, cancellationToken);
        }
    }
}
