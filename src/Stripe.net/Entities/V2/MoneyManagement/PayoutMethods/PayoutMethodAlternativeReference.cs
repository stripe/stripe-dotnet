// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodAlternativeReference : StripeEntity<PayoutMethodAlternativeReference>, IHasId
    {
        /// <summary>
        /// The ID of the alternative resource being referenced.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The type of the alternative reference (e.g., external_account for V1 external accounts).
        /// One of: <c>external_account</c>, or <c>payment_method</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
