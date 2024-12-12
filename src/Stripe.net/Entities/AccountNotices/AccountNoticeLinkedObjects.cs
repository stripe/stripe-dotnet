// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountNoticeLinkedObjects : StripeEntity<AccountNoticeLinkedObjects>
    {
        /// <summary>
        /// Associated <a href="https://stripe.com/docs/api/capabilities">Capability</a>.
        /// </summary>
        [JsonProperty("capability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capability")]
#endif
        public string Capability { get; set; }

        /// <summary>
        /// Associated <a
        /// href="https://stripe.com/docs/api/issuing/credit_underwriting_record">Credit
        /// Underwriting Record</a>.
        /// </summary>
        [JsonProperty("issuing_credit_underwriting_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_credit_underwriting_record")]
#endif
        public string IssuingCreditUnderwritingRecord { get; set; }

        /// <summary>
        /// Associated <a href="https://stripe.com/docs/api/issuing/disputes">Issuing Dispute</a>.
        /// </summary>
        [JsonProperty("issuing_dispute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_dispute")]
#endif
        public string IssuingDispute { get; set; }
    }
}
