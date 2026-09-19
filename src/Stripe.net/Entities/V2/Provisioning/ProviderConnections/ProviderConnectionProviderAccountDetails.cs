// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderConnectionProviderAccountDetails : StripeEntity<ProviderConnectionProviderAccountDetails>, IHasId
    {
        /// <summary>
        /// Services active for the connected account.
        /// </summary>
        [JsonProperty("active_services")]
        [STJS.JsonPropertyName("active_services")]
        public List<ProviderConnectionProviderAccountDetailsActiveService> ActiveServices { get; set; }

        /// <summary>
        /// True when the provider explicitly supplied active_services, including an empty array.
        /// </summary>
        [JsonProperty("active_services_provided")]
        [STJS.JsonPropertyName("active_services_provided")]
        public bool ActiveServicesProvided { get; set; }

        /// <summary>
        /// Display name of the connected account.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Identifier of the connected account at the provider.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Action taken when the account was linked.
        /// One of: <c>created</c>, or <c>linked_existing</c>.
        /// </summary>
        [JsonProperty("link_action")]
        [STJS.JsonPropertyName("link_action")]
        public string LinkAction { get; set; }

        /// <summary>
        /// Primary email address of the connected account.
        /// </summary>
        [JsonProperty("primary_email")]
        [STJS.JsonPropertyName("primary_email")]
        public string PrimaryEmail { get; set; }
    }
}
