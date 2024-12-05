// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentDestinationPaymentMethodDetails : StripeEntity<OutboundPaymentDestinationPaymentMethodDetails>
    {
        [JsonProperty("billing_details")]
        public OutboundPaymentDestinationPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("financial_account")]
        public OutboundPaymentDestinationPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// The type of the payment method used in the OutboundPayment.
        /// One of: <c>financial_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public OutboundPaymentDestinationPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
