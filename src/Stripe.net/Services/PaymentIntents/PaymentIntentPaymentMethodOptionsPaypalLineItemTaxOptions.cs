// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsPaypalLineItemTaxOptions : INestedOptions
    {
        /// <summary>
        /// The tax for a single unit of the line item in minor units. Cannot be a negative number.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The tax behavior for the line item.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("behavior")]
        public string Behavior { get; set; }
    }
}
