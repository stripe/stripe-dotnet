// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferDestinationPaymentMethodDetails : StripeEntity<OutboundTransferDestinationPaymentMethodDetails>
    {
        [JsonProperty("billing_details")]
        public OutboundTransferDestinationPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The type of the payment method used in the OutboundTransfer.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public OutboundTransferDestinationPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
