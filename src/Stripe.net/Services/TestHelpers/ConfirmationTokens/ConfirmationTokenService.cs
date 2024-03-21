// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConfirmationTokenService : Service<ConfirmationToken>
    {
        public ConfirmationTokenService()
        {
        }

        public ConfirmationTokenService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/confirmation_tokens";

        /// <summary>
        /// <p>Creates a test mode Confirmation Token server side for your integration tests.</p>.
        /// </summary>
        public virtual ConfirmationToken Create(ConfirmationTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ConfirmationToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/confirmation_tokens", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Creates a test mode Confirmation Token server side for your integration tests.</p>.
        /// </summary>
        public virtual Task<ConfirmationToken> CreateAsync(ConfirmationTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConfirmationToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/confirmation_tokens", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
