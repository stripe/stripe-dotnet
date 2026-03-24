// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadencePayer : StripeEntity<CadencePayer>
    {
        /// <summary>
        /// The ID of the Billing Profile object which determines how a bill will be paid.
        /// </summary>
        [JsonProperty("billing_profile")]
        [STJS.JsonPropertyName("billing_profile")]
        public string BillingProfile { get; set; }

        /// <summary>
        /// The ID of the Customer object.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// A string identifying the type of the payer. Currently the only supported value is
        /// <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
