// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsLodgingDatumAffiliate : StripeEntity<PaymentIntentPaymentDetailsLodgingDatumAffiliate>
    {
        /// <summary>
        /// Affiliate partner code.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Affiliate partner name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
