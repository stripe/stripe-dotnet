// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentApplyCustomerBalanceOptions : BaseOptions
    {
        /// <summary>
        /// Amount intended to be applied to this PaymentIntent from the customer’s cash balance.
        ///
        /// A positive integer representing how much to charge in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency).
        ///
        /// The maximum amount is the amount of the PaymentIntent.
        ///
        /// When omitted, the amount defaults to the remaining amount requested on the
        /// PaymentIntent.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
