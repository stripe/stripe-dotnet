// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OnrampTransactionLimitsService : Service,
        ISingletonRetrievable<OnrampTransactionLimits>
    {
        public OnrampTransactionLimitsService()
        {
        }

        internal OnrampTransactionLimitsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public OnrampTransactionLimitsService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the remaining onramp limit for a crypto customer.</p>.
        /// </summary>
        public virtual OnrampTransactionLimits Get(RequestOptions requestOptions = null)
        {
            return this.Request<OnrampTransactionLimits>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_transaction_limits", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the remaining onramp limit for a crypto customer.</p>.
        /// </summary>
        public virtual Task<OnrampTransactionLimits> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OnrampTransactionLimits>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_transaction_limits", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the remaining onramp limit for a crypto customer.</p>.
        /// </summary>
        public virtual OnrampTransactionLimits Get(OnrampTransactionLimitsGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OnrampTransactionLimits>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_transaction_limits", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the remaining onramp limit for a crypto customer.</p>.
        /// </summary>
        public virtual Task<OnrampTransactionLimits> GetAsync(OnrampTransactionLimitsGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OnrampTransactionLimits>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/onramp_transaction_limits", options, requestOptions, cancellationToken);
        }
    }
}
