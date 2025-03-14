// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferDestinationPaymentMethodDetails : StripeEntity<OutboundTransferDestinationPaymentMethodDetails>
    {
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public OutboundTransferDestinationPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public OutboundTransferDestinationPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// The type of the payment method used in the OutboundTransfer.
        /// One of: <c>financial_account</c>, or <c>us_bank_account</c>.
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
        public OutboundTransferDestinationPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
