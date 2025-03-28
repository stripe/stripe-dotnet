// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
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
    }
}
