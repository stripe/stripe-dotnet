// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConfigurationService : Service<Configuration>,
        ICreatable<Configuration, ConfigurationCreateOptions>,
        IDeletable<Configuration, ConfigurationDeleteOptions>,
        IListable<Configuration, ConfigurationListOptions>,
        IRetrievable<Configuration, ConfigurationGetOptions>,
        IUpdatable<Configuration, ConfigurationUpdateOptions>
    {
        public ConfigurationService()
        {
        }

        public ConfigurationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/terminal/configurations";

        /// <summary>
        /// <p>Creates a new <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Configuration Create(ConfigurationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Configuration>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/configurations", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Creates a new <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Task<Configuration> CreateAsync(ConfigurationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Configuration>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/configurations", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes a <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Configuration Delete(string id, ConfigurationDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Configuration>(BaseAddress.Api, HttpMethod.Delete, $"/v1/terminal/configurations/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Deletes a <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Task<Configuration> DeleteAsync(string id, ConfigurationDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Configuration>(BaseAddress.Api, HttpMethod.Delete, $"/v1/terminal/configurations/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Configuration Get(string id, ConfigurationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Configuration>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/configurations/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Retrieves a <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Task<Configuration> GetAsync(string id, ConfigurationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Configuration>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/configurations/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Configuration</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Configuration> List(ConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Configuration>>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/configurations", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Returns a list of <c>Configuration</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Configuration>> ListAsync(ConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Configuration>>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/configurations", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Configuration</c> objects.</p>.
        /// </summary>
        public virtual IEnumerable<Configuration> ListAutoPaging(ConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Configuration>($"/v1/terminal/configurations", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Returns a list of <c>Configuration</c> objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Configuration> ListAutoPagingAsync(ConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Configuration>($"/v1/terminal/configurations", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a new <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Configuration Update(string id, ConfigurationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Configuration>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/configurations/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Updates a new <c>Configuration</c> object.</p>.
        /// </summary>
        public virtual Task<Configuration> UpdateAsync(string id, ConfigurationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Configuration>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/configurations/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
