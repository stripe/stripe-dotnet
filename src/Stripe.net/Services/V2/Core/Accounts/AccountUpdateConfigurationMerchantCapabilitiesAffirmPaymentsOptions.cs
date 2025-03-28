// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationMerchantCapabilitiesAffirmPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// To request a new Capability for an account, pass true. There can be a delay before the
        /// requested Capability becomes active.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif
        public bool? Requested { get; set; }
    }
}
