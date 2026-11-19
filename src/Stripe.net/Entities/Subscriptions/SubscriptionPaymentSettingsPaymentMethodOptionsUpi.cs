// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsUpi : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsUpi>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account. Defaults to
        /// <c>not_specified</c>. Omitting this parameter on an update preserves the saved value;
        /// passing <c>not_specified</c> clears it. Early collection is best effort and doesn't
        /// guarantee an exact debit date.
        /// </summary>
        [JsonProperty("debit_behavior")]
        [STJS.JsonPropertyName("debit_behavior")]
        public string DebitBehavior { get; set; }

        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUpiMandateOptions MandateOptions { get; set; }
    }
}
