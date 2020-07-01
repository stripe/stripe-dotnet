namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReaderService : Service<Reader>,
        ICreatable<Reader, ReaderCreateOptions>,
        IDeletable<Reader, ReaderDeleteOptions>,
        IListable<Reader, ReaderListOptions>,
        IRetrievable<Reader, ReaderGetOptions>,
        IUpdatable<Reader, ReaderUpdateOptions>
    {
        public ReaderService()
            : base(null)
        {
        }

        public ReaderService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/terminal/readers";

        public virtual Reader Create(ReaderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Reader> CreateAsync(ReaderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Reader Delete(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, options, requestOptions);
        }

        public virtual Task<Reader> DeleteAsync(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Reader Get(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Reader> GetAsync(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Reader> List(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Reader>> ListAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Reader> ListAutoPaging(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Reader> ListAutoPagingAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Reader Update(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Reader> UpdateAsync(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
