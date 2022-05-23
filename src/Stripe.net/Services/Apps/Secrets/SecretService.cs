// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SecretService : Service<Secret>,
        ICreatable<Secret, SecretCreateOptions>,
        IListable<Secret, SecretListOptions>
    {
        public SecretService()
            : base(null)
        {
        }

        public SecretService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/apps/secrets";

        public virtual Secret Create(SecretCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Secret> CreateAsync(SecretCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Secret DeleteWhere(SecretDeleteWhereOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("delete")}", options, requestOptions);
        }

        public virtual Task<Secret> DeleteWhereAsync(SecretDeleteWhereOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("delete")}", options, requestOptions, cancellationToken);
        }

        public virtual Secret Find(SecretFindOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"{this.InstanceUrl("find")}", options, requestOptions);
        }

        public virtual Task<Secret> FindAsync(SecretFindOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, $"{this.InstanceUrl("find")}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Secret> List(SecretListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Secret>> ListAsync(SecretListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Secret> ListAutoPaging(SecretListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Secret> ListAutoPagingAsync(SecretListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
