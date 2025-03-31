// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceMandateNotificationSepaDebit : StripeEntity<SourceMandateNotificationSepaDebit>
    {
        /// <summary>
        /// SEPA creditor ID.
        /// </summary>
        [JsonProperty("creditor_identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("creditor_identifier")]
#endif
        public string CreditorIdentifier { get; set; }

        /// <summary>
        /// Last 4 digits of the account number associated with the debit.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// Mandate reference associated with the debit.
        /// </summary>
        [JsonProperty("mandate_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_reference")]
#endif
        public string MandateReference { get; set; }
    }
}
