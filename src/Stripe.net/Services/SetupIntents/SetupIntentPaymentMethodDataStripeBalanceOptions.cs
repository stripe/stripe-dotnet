// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodDataStripeBalanceOptions : INestedOptions
    {
        /// <summary>
        /// The connected account ID whose Stripe balance to use as the source of payment.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The <a
        /// href="https://docs.stripe.com/api/balance/balance_object#balance_object-available-source_types">source_type</a>
        /// of the balance.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// </summary>
        [JsonProperty("source_type")]
        [STJS.JsonPropertyName("source_type")]
        public string SourceType { get; set; }
    }
}
