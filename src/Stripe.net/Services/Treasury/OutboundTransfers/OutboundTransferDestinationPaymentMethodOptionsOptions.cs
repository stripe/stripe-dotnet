// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferDestinationPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public OutboundTransferDestinationPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
