namespace Stripe.Terminal
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ConnectionTokenService : Service<ConnectionToken>,
        ICreatable<ConnectionToken, ConnectionTokenCreateOptions>
    {
        public ConnectionTokenService()
            : base(null)
        {
        }

        public ConnectionTokenService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/terminal/connection_tokens";

        public virtual ConnectionToken Create(ConnectionTokenCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ConnectionToken> CreateAsync(ConnectionTokenCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}
