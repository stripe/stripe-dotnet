// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceMandateNotificationSepaDebit : StripeEntity<SourceMandateNotificationSepaDebit>
    {
        /// <summary>
        /// SEPA creditor ID.
        /// </summary>
        [JsonProperty("creditor_identifier")]
        [STJS.JsonPropertyName("creditor_identifier")]
        public string CreditorIdentifier { get; set; }

        /// <summary>
        /// Last 4 digits of the account number associated with the debit.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Mandate reference associated with the debit.
        /// </summary>
        [JsonProperty("mandate_reference")]
        [STJS.JsonPropertyName("mandate_reference")]
        public string MandateReference { get; set; }
    }
}
