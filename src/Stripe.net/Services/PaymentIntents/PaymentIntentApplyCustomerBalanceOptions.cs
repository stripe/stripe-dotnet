// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentApplyCustomerBalanceOptions : BaseOptions
    {
        /// <summary>
        /// Amount that you intend to apply to this PaymentIntent from the customer’s cash balance.
        /// If the PaymentIntent was created by an Invoice, the full amount of the PaymentIntent is
        /// applied regardless of this parameter.
        ///
        /// A positive integer representing how much to charge in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (for
        /// example, 100 cents to charge 1 USD or 100 to charge 100 JPY, a zero-decimal currency).
        /// The maximum amount is the amount of the PaymentIntent.
        ///
        /// When you omit the amount, it defaults to the remaining amount requested on the
        /// PaymentIntent.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }
    }
}
