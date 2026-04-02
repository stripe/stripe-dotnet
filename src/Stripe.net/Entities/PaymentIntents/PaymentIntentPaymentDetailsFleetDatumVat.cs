// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFleetDatumVat : StripeEntity<PaymentIntentPaymentDetailsFleetDatumVat>
    {
        /// <summary>
        /// Indicates the merchant's agreement for Invoice on Behalf (IOB) VAT processing.
        /// </summary>
        [JsonProperty("iob_indicator")]
        [STJS.JsonPropertyName("iob_indicator")]
        public string IobIndicator { get; set; }
    }
}
