// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConfirmationTokenService : Service
    {
        public ConfirmationTokenService()
        {
        }

        internal ConfirmationTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ConfirmationTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a test mode Confirmation Token server side for your integration tests.</p>.
        /// </summary>
        public virtual ConfirmationToken Create(ConfirmationTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ConfirmationToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/confirmation_tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a test mode Confirmation Token server side for your integration tests.</p>.
        /// </summary>
        public virtual Task<ConfirmationToken> CreateAsync(ConfirmationTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConfirmationToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/confirmation_tokens", options, requestOptions, cancellationToken);
        }
    }
}
