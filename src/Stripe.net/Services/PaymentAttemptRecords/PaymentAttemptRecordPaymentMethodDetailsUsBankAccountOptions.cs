// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// NACHA ACH return code for a failed US bank account payment.
        /// </summary>
        [JsonProperty("return_code")]
        [STJS.JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }
    }
}
