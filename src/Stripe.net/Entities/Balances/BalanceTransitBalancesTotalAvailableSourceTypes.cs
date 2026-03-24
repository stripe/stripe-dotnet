// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceTransitBalancesTotalAvailableSourceTypes : StripeEntity<BalanceTransitBalancesTotalAvailableSourceTypes>
    {
        /// <summary>
        /// Amount coming from <a href="https://docs.stripe.com/ach-deprecated">legacy US ACH
        /// payments</a>.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public long BankAccount { get; set; }

        /// <summary>
        /// Amount coming from most payment methods, including cards as well as <a
        /// href="https://docs.stripe.com/payments/bank-debits">non-legacy bank debits</a>.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public long Card { get; set; }

        /// <summary>
        /// Amount coming from <a href="https://docs.stripe.com/payments/fpx">FPX</a>, a Malaysian
        /// payment method.
        /// </summary>
        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public long Fpx { get; set; }
    }
}
