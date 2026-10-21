// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationProductEligibilityInquiry : StripeEntity<AuthorizationProductEligibilityInquiry>
    {
        /// <summary>
        /// The anticipated amount that merchants can send before a payment authorization, in the
        /// smallest currency unit.
        /// </summary>
        [JsonProperty("anticipated_amount")]
        [STJS.JsonPropertyName("anticipated_amount")]
        public long? AnticipatedAmount { get; set; }

        /// <summary>
        /// The currency of the anticipated amount that merchants can send before a payment
        /// authorization.
        /// </summary>
        [JsonProperty("anticipated_currency")]
        [STJS.JsonPropertyName("anticipated_currency")]
        public string AnticipatedCurrency { get; set; }
    }
}
