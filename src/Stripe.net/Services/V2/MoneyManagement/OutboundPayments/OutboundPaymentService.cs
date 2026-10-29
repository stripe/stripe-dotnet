// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundPaymentService : Service
    {
        internal OutboundPaymentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OutboundPaymentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels an OutboundPayment. Only processing OutboundPayments can be canceled.
        /// </summary>
        public virtual OutboundPayment Cancel(string id, OutboundPaymentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_payments/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels an OutboundPayment. Only processing OutboundPayments can be canceled.
        /// </summary>
        public virtual Task<OutboundPayment> CancelAsync(string id, OutboundPaymentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_payments/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates an OutboundPayment.
        /// </summary>
        public virtual OutboundPayment Create(OutboundPaymentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_payments", options, requestOptions);
        }

        /// <summary>
        /// Creates an OutboundPayment.
        /// </summary>
        public virtual Task<OutboundPayment> CreateAsync(OutboundPaymentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing OutboundPayment by passing the unique
        /// OutboundPayment ID from either the OutboundPayment create or list response.
        /// </summary>
        public virtual OutboundPayment Get(string id, OutboundPaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPayment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_payments/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing OutboundPayment by passing the unique
        /// OutboundPayment ID from either the OutboundPayment create or list response.
        /// </summary>
        public virtual Task<OutboundPayment> GetAsync(string id, OutboundPaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPayment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_payments/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of OutboundPayments that match the provided filters.
        /// </summary>
        public virtual V2.StripeList<OutboundPayment> List(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<OutboundPayment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_payments", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of OutboundPayments that match the provided filters.
        /// </summary>
        public virtual Task<V2.StripeList<OutboundPayment>> ListAsync(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<OutboundPayment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of OutboundPayments that match the provided filters.
        /// </summary>
        public virtual IEnumerable<OutboundPayment> ListAutoPaging(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<OutboundPayment>($"/v2/money_management/outbound_payments", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of OutboundPayments that match the provided filters.
        /// </summary>
        public virtual IAsyncEnumerable<OutboundPayment> ListAutoPagingAsync(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<OutboundPayment>($"/v2/money_management/outbound_payments", options, requestOptions, cancellationToken);
        }
    }
}
