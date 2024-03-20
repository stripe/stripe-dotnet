// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SecretService : Service<Secret>,
        ICreatable<Secret, SecretCreateOptions>,
        IListable<Secret, SecretListOptions>
    {
        public SecretService()
        {
        }

        public SecretService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/apps/secrets";

        /// <summary>
        /// <p>Create or replace a secret in the secret store.</p>.
        /// </summary>
        public virtual Secret Create(SecretCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Secret>(HttpMethod.Post, $"/v1/apps/secrets", options, requestOptions);
        }

        /// <summary>
        /// <p>Create or replace a secret in the secret store.</p>.
        /// </summary>
        public virtual Task<Secret> CreateAsync(SecretCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Secret>(HttpMethod.Post, $"/v1/apps/secrets", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes a secret from the secret store by name and scope.</p>.
        /// </summary>
        public virtual Secret DeleteWhere(SecretDeleteWhereOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Secret>(HttpMethod.Post, $"/v1/apps/secrets/delete", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes a secret from the secret store by name and scope.</p>.
        /// </summary>
        public virtual Task<Secret> DeleteWhereAsync(SecretDeleteWhereOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Secret>(HttpMethod.Post, $"/v1/apps/secrets/delete", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Finds a secret in the secret store by name and scope.</p>.
        /// </summary>
        public virtual Secret Find(SecretFindOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Secret>(HttpMethod.Get, $"/v1/apps/secrets/find", options, requestOptions);
        }

        /// <summary>
        /// <p>Finds a secret in the secret store by name and scope.</p>.
        /// </summary>
        public virtual Task<Secret> FindAsync(SecretFindOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Secret>(HttpMethod.Get, $"/v1/apps/secrets/find", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all secrets stored on the given scope.</p>.
        /// </summary>
        public virtual StripeList<Secret> List(SecretListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Secret>>(HttpMethod.Get, $"/v1/apps/secrets", options, requestOptions);
        }

        /// <summary>
        /// <p>List all secrets stored on the given scope.</p>.
        /// </summary>
        public virtual Task<StripeList<Secret>> ListAsync(SecretListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Secret>>(HttpMethod.Get, $"/v1/apps/secrets", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all secrets stored on the given scope.</p>.
        /// </summary>
        public virtual IEnumerable<Secret> ListAutoPaging(SecretListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Secret>($"/v1/apps/secrets", options, requestOptions);
        }

        /// <summary>
        /// <p>List all secrets stored on the given scope.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Secret> ListAutoPagingAsync(SecretListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Secret>($"/v1/apps/secrets", options, requestOptions, cancellationToken);
        }
    }
}
