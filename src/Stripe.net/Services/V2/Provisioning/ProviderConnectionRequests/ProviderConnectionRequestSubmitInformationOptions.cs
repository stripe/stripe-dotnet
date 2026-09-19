// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProviderConnectionRequestSubmitInformationOptions : BaseOptions
    {
        /// <summary>
        /// Secret used to confirm the request when submitting on behalf of a resource without an
        /// authenticated session.
        /// </summary>
        [JsonProperty("confirmation_secret")]
        [STJS.JsonPropertyName("confirmation_secret")]
        public string ConfirmationSecret { get; set; }

        /// <summary>
        /// Information requested by the provider, matching the connection's
        /// needs_information_schema.
        /// </summary>
        [JsonProperty("information")]
        [STJS.JsonPropertyName("information")]
        public Dictionary<string, object> Information { get; set; }
    }
}
