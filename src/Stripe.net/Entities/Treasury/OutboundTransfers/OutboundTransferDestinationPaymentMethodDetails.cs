// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferDestinationPaymentMethodDetails : StripeEntity<OutboundTransferDestinationPaymentMethodDetails>
    {
        [JsonProperty("billing_details")]
        public OutboundTransferDestinationPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("financial_account")]
        public OutboundTransferDestinationPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// The type of the payment method used in the OutboundTransfer.
        /// One of: <c>financial_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public OutboundTransferDestinationPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
