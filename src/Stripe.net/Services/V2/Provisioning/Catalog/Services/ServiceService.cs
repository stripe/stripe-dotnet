// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning.Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ServiceService : Service
    {
        internal ServiceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ServiceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Lists services available in the catalog.
        /// </summary>
        public virtual V2.StripeList<V2.Provisioning.ProviderServiceDetail> List(ServiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Provisioning.ProviderServiceDetail>>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/catalog/services", options, requestOptions);
        }

        /// <summary>
        /// Lists services available in the catalog.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Provisioning.ProviderServiceDetail>> ListAsync(ServiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Provisioning.ProviderServiceDetail>>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/catalog/services", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists services available in the catalog.
        /// </summary>
        public virtual IEnumerable<V2.Provisioning.ProviderServiceDetail> ListAutoPaging(ServiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Provisioning.ProviderServiceDetail>($"/v2/provisioning/catalog/services", options, requestOptions);
        }

        /// <summary>
        /// Lists services available in the catalog.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Provisioning.ProviderServiceDetail> ListAutoPagingAsync(ServiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Provisioning.ProviderServiceDetail>($"/v2/provisioning/catalog/services", options, requestOptions, cancellationToken);
        }
    }
}
