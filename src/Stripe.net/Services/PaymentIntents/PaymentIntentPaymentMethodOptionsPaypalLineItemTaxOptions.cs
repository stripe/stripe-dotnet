// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsPaypalLineItemTaxOptions : INestedOptions
    {
        /// <summary>
        /// The tax for a single unit of the line item in minor units. Cannot be a negative number.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The tax behavior for the line item.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("behavior")]
        [STJS.JsonPropertyName("behavior")]
        public string Behavior { get; set; }
    }
}
