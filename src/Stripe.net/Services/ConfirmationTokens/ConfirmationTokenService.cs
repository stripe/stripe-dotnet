// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConfirmationTokenService : Service<ConfirmationToken>,
        IRetrievable<ConfirmationToken, ConfirmationTokenGetOptions>
    {
        public ConfirmationTokenService()
        {
        }

        public ConfirmationTokenService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/confirmation_tokens";

        /// <summary>
        /// <p>Retrieves an existing ConfirmationToken object</p>.
        /// </summary>
        public virtual ConfirmationToken Get(string id, ConfirmationTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ConfirmationToken>(HttpMethod.Get, $"/v1/confirmation_tokens/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an existing ConfirmationToken object</p>.
        /// </summary>
        public virtual Task<ConfirmationToken> GetAsync(string id, ConfirmationTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConfirmationToken>(HttpMethod.Get, $"/v1/confirmation_tokens/{id}", options, requestOptions, cancellationToken);
        }
    }
}
