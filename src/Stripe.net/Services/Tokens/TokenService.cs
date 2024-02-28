// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TokenService : Service<Token>,
        ICreatable<Token, TokenCreateOptions>,
        IRetrievable<Token, TokenGetOptions>
    {
        public TokenService()
            : base(null)
        {
        }

        public TokenService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tokens";

        public virtual Token Create(TokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(HttpMethod.Post, $"/v1/tokens", options, requestOptions);
        }

        public virtual Task<Token> CreateAsync(TokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(HttpMethod.Post, $"/v1/tokens", options, requestOptions, cancellationToken);
        }

        public virtual Token Get(string id, TokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(HttpMethod.Get, $"/v1/tokens/{id}", options, requestOptions);
        }

        public virtual Task<Token> GetAsync(string id, TokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(HttpMethod.Get, $"/v1/tokens/{id}", options, requestOptions, cancellationToken);
        }
    }
}
