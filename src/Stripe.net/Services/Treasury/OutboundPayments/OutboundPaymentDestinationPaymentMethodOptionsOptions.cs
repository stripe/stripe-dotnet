// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentDestinationPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public OutboundPaymentDestinationPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
