// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundPresentmentDetails : StripeEntity<RefundPresentmentDetails>
    {
        /// <summary>
        /// Amount intended to be collected by this payment, denominated in
        /// <c>presentment_currency</c>.
        /// </summary>
        [JsonProperty("presentment_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("presentment_amount")]
#endif
        public long PresentmentAmount { get; set; }

        /// <summary>
        /// Currency presented to the customer during payment.
        /// </summary>
        [JsonProperty("presentment_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("presentment_currency")]
#endif
        public string PresentmentCurrency { get; set; }
    }
}
