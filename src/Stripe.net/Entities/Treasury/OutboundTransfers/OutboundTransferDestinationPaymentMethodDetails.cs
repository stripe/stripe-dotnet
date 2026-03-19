// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundTransferDestinationPaymentMethodDetails : StripeEntity<OutboundTransferDestinationPaymentMethodDetails>
    {
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public OutboundTransferDestinationPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public OutboundTransferDestinationPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// The type of the payment method used in the OutboundTransfer.
        /// One of: <c>financial_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public OutboundTransferDestinationPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
