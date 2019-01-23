namespace Stripe.Terminal
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ReaderService : Service<Reader>,
        ICreatable<Reader, ReaderCreateOptions>
    {
        public ReaderService()
            : base(null)
        {
        }

        public ReaderService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/terminal/readers";

        public virtual Reader Create(ReaderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Reader> CreateAsync(ReaderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Reader Delete(string readerId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(readerId, null, requestOptions);
        }

        public virtual Task<Reader> DeleteAsync(string readerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(readerId, null, requestOptions, cancellationToken);
        }

        public virtual Reader Get(string readerId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(readerId, null, requestOptions);
        }

        public virtual Task<Reader> GetAsync(string readerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(readerId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Reader> List(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Reader>> ListAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual Reader Update(string readerId, ReaderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(readerId, options, requestOptions);
        }

        public virtual Task<Reader> UpdateAsync(string readerId, ReaderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(readerId, options, requestOptions, cancellationToken);
        }
    }
}
