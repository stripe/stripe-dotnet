// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardFleetData : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardFleetData>
    {
        /// <summary>
        /// The type of product being purchased at this line item.
        /// </summary>
        [JsonProperty("product_type")]
        [STJS.JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// The type of service received at the acceptor location.
        /// </summary>
        [JsonProperty("service_type")]
        [STJS.JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}
