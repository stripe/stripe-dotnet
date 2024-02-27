// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConnectionTokenService : Service<ConnectionToken>,
        ICreatable<ConnectionToken, ConnectionTokenCreateOptions>
    {
        public ConnectionTokenService()
            : base(null)
        {
        }

        public ConnectionTokenService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/terminal/connection_tokens";

        public virtual ConnectionToken Create(ConnectionTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ConnectionToken>(HttpMethod.Post, $"/v1/terminal/connection_tokens", options, requestOptions);
        }

        public virtual Task<ConnectionToken> CreateAsync(ConnectionTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConnectionToken>(HttpMethod.Post, $"/v1/terminal/connection_tokens", options, requestOptions, cancellationToken);
        }
    }
}
