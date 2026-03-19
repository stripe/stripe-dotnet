// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodAlternativeReference : StripeEntity<PayoutMethodAlternativeReference>, IHasId
    {
        /// <summary>
        /// The ID of the alternative resource being referenced.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the alternative reference (e.g., external_account for V1 external accounts).
        /// One of: <c>external_account</c>, or <c>payment_method</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
