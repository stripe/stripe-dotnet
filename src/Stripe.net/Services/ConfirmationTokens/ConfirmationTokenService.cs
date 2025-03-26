// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConfirmationTokenService : Service<ConfirmationToken>,
        IRetrievable<ConfirmationToken, ConfirmationTokenGetOptions>
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
        /// <p>Retrieves an existing ConfirmationToken object</p>.
        /// </summary>
        public virtual ConfirmationToken Get(string id, ConfirmationTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ConfirmationToken>(BaseAddress.Api, HttpMethod.Get, $"/v1/confirmation_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an existing ConfirmationToken object</p>.
        /// </summary>
        public virtual Task<ConfirmationToken> GetAsync(string id, ConfirmationTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConfirmationToken>(BaseAddress.Api, HttpMethod.Get, $"/v1/confirmation_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
