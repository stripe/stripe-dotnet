// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountNoticeLinkedObjects : StripeEntity<AccountNoticeLinkedObjects>
    {
        /// <summary>
        /// Associated <a href="https://stripe.com/docs/api/capabilities">Capability</a>.
        /// </summary>
        [JsonProperty("capability")]
        public string Capability { get; set; }

        /// <summary>
        /// Associated <a
        /// href="https://stripe.com/docs/api/issuing/credit_underwriting_record">Credit
        /// Underwriting Record</a>.
        /// </summary>
        [JsonProperty("issuing_credit_underwriting_record")]
        public string IssuingCreditUnderwritingRecord { get; set; }

        /// <summary>
        /// Associated <a href="https://stripe.com/docs/api/issuing/disputes">Issuing Dispute</a>.
        /// </summary>
        [JsonProperty("issuing_dispute")]
        public string IssuingDispute { get; set; }
    }
}
