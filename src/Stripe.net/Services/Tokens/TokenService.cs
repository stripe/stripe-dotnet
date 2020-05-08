namespace Stripe
{
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

        public override string BasePath => "/v1/tokens";

        public virtual Token Create(TokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Token> CreateAsync(TokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Token Get(string id, TokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Token> GetAsync(string id, TokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
