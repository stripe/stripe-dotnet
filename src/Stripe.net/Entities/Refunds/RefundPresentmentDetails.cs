// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundPresentmentDetails : StripeEntity<RefundPresentmentDetails>
    {
        /// <summary>
        /// Amount intended to be collected by this payment, denominated in
        /// <c>presentment_currency</c>.
        /// </summary>
        [JsonProperty("presentment_amount")]
        [STJS.JsonPropertyName("presentment_amount")]
        public long PresentmentAmount { get; set; }

        /// <summary>
        /// Currency presented to the customer during payment.
        /// </summary>
        [JsonProperty("presentment_currency")]
        [STJS.JsonPropertyName("presentment_currency")]
        public string PresentmentCurrency { get; set; }
    }
}
