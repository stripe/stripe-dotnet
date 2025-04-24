// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundPaymentQuoteService : Service
    {
        internal OutboundPaymentQuoteService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OutboundPaymentQuoteService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates an OutboundPaymentQuote usable in an OutboundPayment.
        /// </summary>
        public virtual OutboundPaymentQuote Create(OutboundPaymentQuoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPaymentQuote>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_payment_quotes", options, requestOptions);
        }

        /// <summary>
        /// Creates an OutboundPaymentQuote usable in an OutboundPayment.
        /// </summary>
        public virtual Task<OutboundPaymentQuote> CreateAsync(OutboundPaymentQuoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPaymentQuote>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_payment_quotes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing OutboundPaymentQuote by passing the unique
        /// OutboundPaymentQuote ID.
        /// </summary>
        public virtual OutboundPaymentQuote Get(string id, OutboundPaymentQuoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPaymentQuote>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_payment_quotes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing OutboundPaymentQuote by passing the unique
        /// OutboundPaymentQuote ID.
        /// </summary>
        public virtual Task<OutboundPaymentQuote> GetAsync(string id, OutboundPaymentQuoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPaymentQuote>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_payment_quotes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
