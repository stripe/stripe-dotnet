// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCurrentAttemptPaymentMethodDetails : StripeEntity<SessionCurrentAttemptPaymentMethodDetails>
    {
        /// <summary>
        /// Indicates whether this payment method can be shown again to its customer in a checkout
        /// flow.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        [STJS.JsonPropertyName("allow_redisplay")]
        public string AllowRedisplay { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public SessionCurrentAttemptPaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public SessionCurrentAttemptPaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public SessionCurrentAttemptPaymentMethodDetailsBoleto Boleto { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public SessionCurrentAttemptPaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public SessionCurrentAttemptPaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public SessionCurrentAttemptPaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// The type of payment method the customer is attempting to pay with. An additional hash is
        /// included in the payment method details with a name matching this value. It contains
        /// additional information specific to the payment method type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public SessionCurrentAttemptPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
