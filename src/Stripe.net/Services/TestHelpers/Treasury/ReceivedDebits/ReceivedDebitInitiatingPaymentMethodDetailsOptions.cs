// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitInitiatingPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The source type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Optional fields for <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public ReceivedDebitInitiatingPaymentMethodDetailsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
