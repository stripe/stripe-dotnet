// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateNotificationSepaDebit : StripeEntity<SourceMandateNotificationSepaDebit>
    {
        /// <summary>
        /// SEPA creditor ID.
        /// </summary>
        [JsonProperty("creditor_identifier")]
        public string CreditorIdentifier { get; set; }

        /// <summary>
        /// Last 4 digits of the account number associated with the debit.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Mandate reference associated with the debit.
        /// </summary>
        [JsonProperty("mandate_reference")]
        public string MandateReference { get; set; }
    }
}
