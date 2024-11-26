// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodConfigurationDetails : StripeEntity<SetupIntentPaymentMethodConfigurationDetails>, IHasId
    {
        /// <summary>
        /// ID of the payment method configuration used.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// ID of the parent payment method configuration used.
        /// </summary>
        [JsonProperty("parent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("parent")]
#endif
        public string Parent { get; set; }
    }
}
