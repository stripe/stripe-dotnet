// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentCadenceDataPayer : StripeEntity<IntentCadenceDataPayer>
    {
        /// <summary>
        /// The ID of the Billing Profile object which determines how a bill will be paid.
        /// </summary>
        [JsonProperty("billing_profile")]
        [STJS.JsonPropertyName("billing_profile")]
        public string BillingProfile { get; set; }

        /// <summary>
        /// Data for creating a new profile.
        /// </summary>
        [JsonProperty("billing_profile_data")]
        [STJS.JsonPropertyName("billing_profile_data")]
        public IntentCadenceDataPayerBillingProfileData BillingProfileData { get; set; }
    }
}
