// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentIntentService : Service
    {
        public PaymentIntentService()
        {
        }

        internal PaymentIntentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentIntentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Simulate an incoming crypto deposit for a testmode PaymentIntent with
        /// <c>payment_method_options[crypto][mode]=deposit</c>. The <c>transaction_hash</c>
        /// parameter determines whether the simulated deposit succeeds or fails. Learn more about
        /// <a
        /// href="https://stripe.com/docs/payments/deposit-mode-stablecoin-payments#test-your-integration">testing
        /// your integration</a>.</p>.
        /// </summary>
        public virtual PaymentIntent SimulateCryptoDeposit(string id, PaymentIntentSimulateCryptoDepositOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/payment_intents/{WebUtility.UrlEncode(id)}/simulate_crypto_deposit", options, requestOptions);
        }

        /// <summary>
        /// <p>Simulate an incoming crypto deposit for a testmode PaymentIntent with
        /// <c>payment_method_options[crypto][mode]=deposit</c>. The <c>transaction_hash</c>
        /// parameter determines whether the simulated deposit succeeds or fails. Learn more about
        /// <a
        /// href="https://stripe.com/docs/payments/deposit-mode-stablecoin-payments#test-your-integration">testing
        /// your integration</a>.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> SimulateCryptoDepositAsync(string id, PaymentIntentSimulateCryptoDepositOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/payment_intents/{WebUtility.UrlEncode(id)}/simulate_crypto_deposit", options, requestOptions, cancellationToken);
        }
    }
}
