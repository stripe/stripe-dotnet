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

        public override string BasePath => "/v1/tokens";

        public virtual Token Create(TokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Token> CreateAsync(TokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Token Get(string tokenId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(tokenId, null, requestOptions);
        }

        public virtual Task<Token> GetAsync(string tokenId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(tokenId, null, requestOptions, cancellationToken);
        }
    }
}
