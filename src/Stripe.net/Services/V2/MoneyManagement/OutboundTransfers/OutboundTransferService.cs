// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundTransferService : Service
    {
        internal OutboundTransferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OutboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels an OutboundTransfer. Only processing OutboundTransfers can be canceled.
        /// </summary>
        public virtual V2.OutboundTransfer Cancel(string id, OutboundTransferCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_transfers/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels an OutboundTransfer. Only processing OutboundTransfers can be canceled.
        /// </summary>
        public virtual Task<V2.OutboundTransfer> CancelAsync(string id, OutboundTransferCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_transfers/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates an OutboundTransfer.
        /// </summary>
        public virtual V2.OutboundTransfer Create(OutboundTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// Creates an OutboundTransfer.
        /// </summary>
        public virtual Task<V2.OutboundTransfer> CreateAsync(OutboundTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing OutboundTransfer by passing the unique
        /// OutboundTransfer ID from either the OutboundPayment create or list response.
        /// </summary>
        public virtual V2.OutboundTransfer Get(string id, OutboundTransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.OutboundTransfer>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_transfers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing OutboundTransfer by passing the unique
        /// OutboundTransfer ID from either the OutboundPayment create or list response.
        /// </summary>
        public virtual Task<V2.OutboundTransfer> GetAsync(string id, OutboundTransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.OutboundTransfer>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_transfers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of OutboundTransfers that match the provided filters.
        /// </summary>
        public virtual V2.StripeList<V2.OutboundTransfer> List(OutboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.OutboundTransfer>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of OutboundTransfers that match the provided filters.
        /// </summary>
        public virtual Task<V2.StripeList<V2.OutboundTransfer>> ListAsync(OutboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.OutboundTransfer>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of OutboundTransfers that match the provided filters.
        /// </summary>
        public virtual IEnumerable<V2.OutboundTransfer> ListAutoPaging(OutboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.OutboundTransfer>($"/v2/money_management/outbound_transfers", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of OutboundTransfers that match the provided filters.
        /// </summary>
        public virtual IAsyncEnumerable<V2.OutboundTransfer> ListAutoPagingAsync(OutboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.OutboundTransfer>($"/v2/money_management/outbound_transfers", options, requestOptions, cancellationToken);
        }
    }
}
