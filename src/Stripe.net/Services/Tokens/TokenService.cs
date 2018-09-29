namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TokenService : Service<Token>,
        ICreatable<Token, TokenCreateOptions>,
        IRetrievable<Token>
    {
        public TokenService()
            : base(null)
        {
        }

        public TokenService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Token Create(TokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/tokens", requestOptions, options);
        }

        public virtual Token Get(string tokenId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/tokens/{tokenId}", requestOptions);
        }

        public virtual Task<Token> CreateAsync(TokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/tokens", requestOptions, cancellationToken, options);
        }

        public virtual Task<Token> GetAsync(string tokenId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/tokens/{tokenId}", requestOptions, cancellationToken);
        }
    }
}
