// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferOriginPaymentMethodDetails : StripeEntity<InboundTransferOriginPaymentMethodDetails>
    {
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public InboundTransferOriginPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The type of the payment method used in the InboundTransfer.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public InboundTransferOriginPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
