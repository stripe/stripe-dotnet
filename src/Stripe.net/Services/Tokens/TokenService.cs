// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
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

        internal TokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a single-use token that represents a bank account’s details. You can use this
        /// token with any v1 API method in place of a bank account dictionary. You can only use
        /// this token once. To do so, attach it to a <a
        /// href="https://stripe.com/docs/api#accounts">connected account</a> where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts.</p>.
        /// </summary>
        public virtual Token Create(TokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(BaseAddress.Api, HttpMethod.Post, $"/v1/tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a single-use token that represents a bank account’s details. You can use this
        /// token with any v1 API method in place of a bank account dictionary. You can only use
        /// this token once. To do so, attach it to a <a
        /// href="https://stripe.com/docs/api#accounts">connected account</a> where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts.</p>.
        /// </summary>
        public virtual Task<Token> CreateAsync(TokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(BaseAddress.Api, HttpMethod.Post, $"/v1/tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the token with the given ID.</p>.
        /// </summary>
        public virtual Token Get(string id, TokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Token>(BaseAddress.Api, HttpMethod.Get, $"/v1/tokens/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the token with the given ID.</p>.
        /// </summary>
        public virtual Task<Token> GetAsync(string id, TokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Token>(BaseAddress.Api, HttpMethod.Get, $"/v1/tokens/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
