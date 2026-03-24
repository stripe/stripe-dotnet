// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodDataPaytoOptions : INestedOptions
    {
        /// <summary>
        /// The account number for the bank account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonProperty("bsb_number")]
        [STJS.JsonPropertyName("bsb_number")]
        public string BsbNumber { get; set; }

        /// <summary>
        /// The PayID alias for the bank account.
        /// </summary>
        [JsonProperty("pay_id")]
        [STJS.JsonPropertyName("pay_id")]
        public string PayId { get; set; }
    }
}
