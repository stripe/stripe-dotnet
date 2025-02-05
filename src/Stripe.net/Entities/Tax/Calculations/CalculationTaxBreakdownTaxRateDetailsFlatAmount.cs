// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationTaxBreakdownTaxRateDetailsFlatAmount : StripeEntity<CalculationTaxBreakdownTaxRateDetailsFlatAmount>
    {
        /// <summary>
        /// Amount of the tax when the <c>rate_type</c> is <c>flat_amount</c>. This positive integer
        /// represents how much to charge in the smallest currency unit (e.g., 100 cents to charge
        /// $1.00 or 100 to charge ¥100, a zero-decimal currency). The amount value supports up to
        /// eight digits (e.g., a value of 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
