// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetails : StripeEntity<GrantedTokenPaymentMethodDetails>
    {
        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public GrantedTokenPaymentMethodDetailsAffirm Affirm { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public GrantedTokenPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public GrantedTokenPaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public GrantedTokenPaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public GrantedTokenPaymentMethodDetailsLink Link { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>affirm</c>, <c>card</c>, <c>klarna</c>, <c>link</c>, or <c>shop_pay</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
