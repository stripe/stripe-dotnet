// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public class SettingsService : Service, ISingletonRetrievable<Settings>
    {
        public SettingsService()
        {
        }

        internal SettingsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SettingsService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Settings Get(RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/settings", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Task<Settings> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/settings", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Settings Get(SettingsGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/settings", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Task<Settings> GetAsync(SettingsGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes a Settings update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchUpdate(SettingsUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", null },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                requestBody["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(requestBody, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// <p>Updates Tax <c>Settings</c> parameters used in tax calculations. All parameters are
        /// editable but none can be removed once set.</p>.
        /// </summary>
        public virtual Settings Update(SettingsUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/settings", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates Tax <c>Settings</c> parameters used in tax calculations. All parameters are
        /// editable but none can be removed once set.</p>.
        /// </summary>
        public virtual Task<Settings> UpdateAsync(SettingsUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/settings", options, requestOptions, cancellationToken);
        }
    }
}
