// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TokenService : Service<Token>,
        IListable<Token, TokenListOptions>,
        IRetrievable<Token, TokenGetOptions>,
        IUpdatable<Token, TokenUpdateOptions>
    {
        public TokenService()
        {
        }

        public TokenService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/tokens";

        /// <summary>
        /// <p>Retrieves an Issuing <c>Token</c> object.</p>.
        /// </summary>
        public virtual Token Get(string id, TokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(HttpMethod.Get, $"/v1/issuing/tokens/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>Token</c> object.</p>.
        /// </summary>
        public virtual Task<Token> GetAsync(string id, TokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(HttpMethod.Get, $"/v1/issuing/tokens/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all Issuing <c>Token</c> objects for a given card.</p>.
        /// </summary>
        public virtual StripeList<Token> List(TokenListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Token>>(HttpMethod.Get, $"/v1/issuing/tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all Issuing <c>Token</c> objects for a given card.</p>.
        /// </summary>
        public virtual Task<StripeList<Token>> ListAsync(TokenListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Token>>(HttpMethod.Get, $"/v1/issuing/tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all Issuing <c>Token</c> objects for a given card.</p>.
        /// </summary>
        public virtual IEnumerable<Token> ListAutoPaging(TokenListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Token>($"/v1/issuing/tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all Issuing <c>Token</c> objects for a given card.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Token> ListAutoPagingAsync(TokenListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Token>($"/v1/issuing/tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Attempts to update the specified Issuing <c>Token</c> object to the status
        /// specified.</p>.
        /// </summary>
        public virtual Token Update(string id, TokenUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(HttpMethod.Post, $"/v1/issuing/tokens/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Attempts to update the specified Issuing <c>Token</c> object to the status
        /// specified.</p>.
        /// </summary>
        public virtual Task<Token> UpdateAsync(string id, TokenUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(HttpMethod.Post, $"/v1/issuing/tokens/{id}", options, requestOptions, cancellationToken);
        }
    }
}
