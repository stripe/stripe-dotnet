// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodStripeBalanceOptions : INestedOptions
    {
        /// <summary>
        /// The connected account ID whose Stripe balance to use as the source of payment.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The <a
        /// href="https://docs.stripe.com/api/balance/balance_object#balance_object-available-source_types">source_type</a>
        /// of the balance.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// </summary>
        [JsonProperty("source_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_type")]
#endif
        public string SourceType { get; set; }
    }
}
