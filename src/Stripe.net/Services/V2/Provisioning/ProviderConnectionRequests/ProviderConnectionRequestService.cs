// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProviderConnectionRequestService : Service
    {
        internal ProviderConnectionRequestService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProviderConnectionRequestService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a new provider connection.
        /// </summary>
        public virtual ProviderConnectionRequest Create(ProviderConnectionRequestCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ProviderConnectionRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/provider_connection_requests", options, requestOptions);
        }

        /// <summary>
        /// Creates a new provider connection.
        /// </summary>
        public virtual Task<ProviderConnectionRequest> CreateAsync(ProviderConnectionRequestCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ProviderConnectionRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/provider_connection_requests", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a provider connection.
        /// </summary>
        public virtual ProviderConnectionRequest Get(string id, ProviderConnectionRequestGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ProviderConnectionRequest>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/provider_connection_requests/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a provider connection.
        /// </summary>
        public virtual Task<ProviderConnectionRequest> GetAsync(string id, ProviderConnectionRequestGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ProviderConnectionRequest>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/provider_connection_requests/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Submits additional information requested by the provider for a provider connection.
        /// </summary>
        public virtual ProviderConnectionRequest SubmitInformation(string id, ProviderConnectionRequestSubmitInformationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ProviderConnectionRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/provider_connection_requests/{WebUtility.UrlEncode(id)}/submit_information", options, requestOptions);
        }

        /// <summary>
        /// Submits additional information requested by the provider for a provider connection.
        /// </summary>
        public virtual Task<ProviderConnectionRequest> SubmitInformationAsync(string id, ProviderConnectionRequestSubmitInformationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ProviderConnectionRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/provider_connection_requests/{WebUtility.UrlEncode(id)}/submit_information", options, requestOptions, cancellationToken);
        }
    }
}
