// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class BalanceInstantAvailableSourceTypes : StripeEntity<BalanceInstantAvailableSourceTypes>
    {
        /// <summary>
        /// Amount coming from <a href="https://docs.stripe.com/ach-deprecated">legacy US ACH
        /// payments</a>.
        /// </summary>
        [JsonProperty("bank_account")]
        public long BankAccount { get; set; }

        /// <summary>
        /// Amount coming from most payment methods, including cards as well as <a
        /// href="https://docs.stripe.com/payments/bank-debits">non-legacy bank debits</a>.
        /// </summary>
        [JsonProperty("card")]
        public long Card { get; set; }

        /// <summary>
        /// Amount coming from <a href="https://docs.stripe.com/payments/fpx">FPX</a>, a Malaysian
        /// payment method.
        /// </summary>
        [JsonProperty("fpx")]
        public long Fpx { get; set; }
    }
}
