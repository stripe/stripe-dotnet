// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsUpiOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account. Defaults to
        /// <c>not_specified</c>. Omit this parameter on an update to preserve the saved value; pass
        /// <c>not_specified</c> to clear it. Early collection is best effort and doesn't guarantee
        /// an exact debit date.
        /// </summary>
        [JsonProperty("debit_behavior")]
        [STJS.JsonPropertyName("debit_behavior")]
        public string DebitBehavior { get; set; }

        /// <summary>
        /// Configuration options for setting up an eMandate.
        /// </summary>
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUpiMandateOptionsOptions MandateOptions { get; set; }
    }
}
