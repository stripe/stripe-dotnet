// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferOriginPaymentMethodDetails : StripeEntity<InboundTransferOriginPaymentMethodDetails>
    {
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public InboundTransferOriginPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The type of the payment method used in the InboundTransfer.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public InboundTransferOriginPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
