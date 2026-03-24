// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountNoticeLinkedObjects : StripeEntity<AccountNoticeLinkedObjects>
    {
        /// <summary>
        /// Associated <a href="https://docs.stripe.com/api/capabilities">Capability</a>.
        /// </summary>
        [JsonProperty("capability")]
        [STJS.JsonPropertyName("capability")]
        public string Capability { get; set; }

        /// <summary>
        /// Associated <a
        /// href="https://docs.stripe.com/api/issuing/credit_underwriting_record">Credit
        /// Underwriting Record</a>.
        /// </summary>
        [JsonProperty("issuing_credit_underwriting_record")]
        [STJS.JsonPropertyName("issuing_credit_underwriting_record")]
        public string IssuingCreditUnderwritingRecord { get; set; }

        /// <summary>
        /// Associated <a href="https://docs.stripe.com/api/issuing/disputes">Issuing Dispute</a>.
        /// </summary>
        [JsonProperty("issuing_dispute")]
        [STJS.JsonPropertyName("issuing_dispute")]
        public string IssuingDispute { get; set; }
    }
}
