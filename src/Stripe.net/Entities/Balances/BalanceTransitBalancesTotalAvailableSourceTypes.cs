// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceTransitBalancesTotalAvailableSourceTypes : StripeEntity<BalanceTransitBalancesTotalAvailableSourceTypes>
    {
        /// <summary>
        /// Amount coming from <a href="https://docs.stripe.com/ach-deprecated">legacy US ACH
        /// payments</a>.
        /// </summary>
        [JsonProperty("bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account")]
#endif
        public long BankAccount { get; set; }

        /// <summary>
        /// Amount coming from most payment methods, including cards as well as <a
        /// href="https://docs.stripe.com/payments/bank-debits">non-legacy bank debits</a>.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public long Card { get; set; }

        /// <summary>
        /// Amount coming from <a href="https://docs.stripe.com/payments/fpx">FPX</a>, a Malaysian
        /// payment method.
        /// </summary>
        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif
        public long Fpx { get; set; }
    }
}
