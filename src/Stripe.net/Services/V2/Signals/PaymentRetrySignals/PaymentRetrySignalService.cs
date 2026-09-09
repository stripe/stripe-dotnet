// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentRetrySignalService : Service
    {
        internal PaymentRetrySignalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PaymentRetrySignalService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves a payment retry signal by ID.
        /// </summary>
        public virtual PaymentRetrySignal Get(string id, PaymentRetrySignalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRetrySignal>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/payment_retry_signals/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a payment retry signal by ID.
        /// </summary>
        public virtual Task<PaymentRetrySignal> GetAsync(string id, PaymentRetrySignalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRetrySignal>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/payment_retry_signals/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
