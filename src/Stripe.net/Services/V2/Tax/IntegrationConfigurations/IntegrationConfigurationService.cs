// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class IntegrationConfigurationService : Service
    {
        internal IntegrationConfigurationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal IntegrationConfigurationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve the tax integration configuration for this account.
        /// </summary>
        public virtual IntegrationConfiguration Get(IntegrationConfigurationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IntegrationConfiguration>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/integration_configurations", options, requestOptions);
        }

        /// <summary>
        /// Retrieve the tax integration configuration for this account.
        /// </summary>
        public virtual Task<IntegrationConfiguration> GetAsync(IntegrationConfigurationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IntegrationConfiguration>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/integration_configurations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update the tax integration configuration for this account.
        /// </summary>
        public virtual IntegrationConfiguration Update(IntegrationConfigurationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IntegrationConfiguration>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/integration_configurations", options, requestOptions);
        }

        /// <summary>
        /// Update the tax integration configuration for this account.
        /// </summary>
        public virtual Task<IntegrationConfiguration> UpdateAsync(IntegrationConfigurationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IntegrationConfiguration>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/integration_configurations", options, requestOptions, cancellationToken);
        }
    }
}
