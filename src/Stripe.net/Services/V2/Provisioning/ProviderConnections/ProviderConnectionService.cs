// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProviderConnectionService : Service
    {
        internal ProviderConnectionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProviderConnectionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Lists the provider connections for the account.
        /// </summary>
        public virtual V2.StripeList<ProviderConnection> List(ProviderConnectionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ProviderConnection>>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/provider_connections", options, requestOptions);
        }

        /// <summary>
        /// Lists the provider connections for the account.
        /// </summary>
        public virtual Task<V2.StripeList<ProviderConnection>> ListAsync(ProviderConnectionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ProviderConnection>>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/provider_connections", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists the provider connections for the account.
        /// </summary>
        public virtual IEnumerable<ProviderConnection> ListAutoPaging(ProviderConnectionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ProviderConnection>($"/v2/provisioning/provider_connections", options, requestOptions);
        }

        /// <summary>
        /// Lists the provider connections for the account.
        /// </summary>
        public virtual IAsyncEnumerable<ProviderConnection> ListAutoPagingAsync(ProviderConnectionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ProviderConnection>($"/v2/provisioning/provider_connections", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Unlinks a provider connection so it can no longer be used to create resources.
        /// </summary>
        public virtual ProviderConnection Unlink(string id, ProviderConnectionUnlinkOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ProviderConnection>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/provider_connections/{WebUtility.UrlEncode(id)}/unlink", options, requestOptions);
        }

        /// <summary>
        /// Unlinks a provider connection so it can no longer be used to create resources.
        /// </summary>
        public virtual Task<ProviderConnection> UnlinkAsync(string id, ProviderConnectionUnlinkOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ProviderConnection>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/provider_connections/{WebUtility.UrlEncode(id)}/unlink", options, requestOptions, cancellationToken);
        }
    }
}
