// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsPaypalOptions : INestedOptions
    {
        /// <summary>
        /// Type of the line item.
        /// One of: <c>digital_goods</c>, <c>donation</c>, or <c>physical_goods</c>.
        /// </summary>
        [JsonProperty("category")]
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Description of the line item.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The Stripe account ID of the connected account that sells the item.
        /// </summary>
        [JsonProperty("sold_by")]
        [STJS.JsonPropertyName("sold_by")]
        public string SoldBy { get; set; }
    }
}
