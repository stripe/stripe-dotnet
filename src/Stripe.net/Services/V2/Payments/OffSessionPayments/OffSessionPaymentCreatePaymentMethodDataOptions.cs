// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreatePaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// Billing information associated with the payment method.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public OffSessionPaymentCreatePaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Contains card details that can be used to create a card PaymentMethod for PCI compliant
        /// users.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public OffSessionPaymentCreatePaymentMethodDataCardOptions Card { get; set; }
    }
}
