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
        {
        }

        public TokenService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tokens";

        /// <summary>
        /// <p>Creates a single-use token that represents a bank account’s details. You can use this
        /// token with any API method in place of a bank account dictionary. You can only use this
        /// token once. To do so, attach it to a <a
        /// href="https://stripe.com/docs/api#accounts">Custom account</a>.</p>.
        /// </summary>
        public virtual Token Create(TokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(HttpMethod.Post, $"/v1/tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a single-use token that represents a bank account’s details. You can use this
        /// token with any API method in place of a bank account dictionary. You can only use this
        /// token once. To do so, attach it to a <a
        /// href="https://stripe.com/docs/api#accounts">Custom account</a>.</p>.
        /// </summary>
        public virtual Task<Token> CreateAsync(TokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(HttpMethod.Post, $"/v1/tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the token with the given ID.</p>.
        /// </summary>
        public virtual Token Get(string id, TokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(HttpMethod.Get, $"/v1/tokens/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the token with the given ID.</p>.
        /// </summary>
        public virtual Task<Token> GetAsync(string id, TokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(HttpMethod.Get, $"/v1/tokens/{id}", options, requestOptions, cancellationToken);
        }
    }
}
