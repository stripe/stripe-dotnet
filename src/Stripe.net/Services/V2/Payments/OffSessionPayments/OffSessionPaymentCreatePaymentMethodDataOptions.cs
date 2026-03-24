// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreatePaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// Billing information associated with the payment method.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public OffSessionPaymentCreatePaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Contains card details that can be used to create a card PaymentMethod for PCI compliant
        /// users.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OffSessionPaymentCreatePaymentMethodDataCardOptions Card { get; set; }
    }
}
