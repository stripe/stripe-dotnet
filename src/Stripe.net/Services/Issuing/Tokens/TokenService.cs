// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class TokenService : Service<Token>,
        IListable<Token, TokenListOptions>,
        IRetrievable<Token, TokenGetOptions>,
        IUpdatable<Token, TokenUpdateOptions>
    {
        public TokenService()
            : base(null)
        {
        }

        public TokenService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/tokens";

        public virtual Token Get(string id, TokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Token> GetAsync(string id, TokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Token> List(TokenListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Token>> ListAsync(TokenListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Token> ListAutoPaging(TokenListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Token> ListAutoPagingAsync(TokenListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual Token Update(string id, TokenUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Token> UpdateAsync(string id, TokenUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
