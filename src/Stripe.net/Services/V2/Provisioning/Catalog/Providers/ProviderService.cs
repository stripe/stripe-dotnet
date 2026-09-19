// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning.Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProviderService : Service
    {
        internal ProviderService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProviderService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Lists providers available in the catalog.
        /// </summary>
        public virtual V2.StripeList<V2.Provisioning.Provider> List(ProviderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Provisioning.Provider>>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/catalog/providers", options, requestOptions);
        }

        /// <summary>
        /// Lists providers available in the catalog.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Provisioning.Provider>> ListAsync(ProviderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Provisioning.Provider>>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/catalog/providers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists providers available in the catalog.
        /// </summary>
        public virtual IEnumerable<V2.Provisioning.Provider> ListAutoPaging(ProviderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Provisioning.Provider>($"/v2/provisioning/catalog/providers", options, requestOptions);
        }

        /// <summary>
        /// Lists providers available in the catalog.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Provisioning.Provider> ListAutoPagingAsync(ProviderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Provisioning.Provider>($"/v2/provisioning/catalog/providers", options, requestOptions, cancellationToken);
        }
    }
}
