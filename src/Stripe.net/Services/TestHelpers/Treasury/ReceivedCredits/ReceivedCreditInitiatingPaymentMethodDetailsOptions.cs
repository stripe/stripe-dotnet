// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedCreditInitiatingPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The source type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Optional fields for <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ReceivedCreditInitiatingPaymentMethodDetailsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
