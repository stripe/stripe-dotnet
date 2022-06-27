// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CouponCurrencyOptionsBamOptions : INestedOptions
    {
        /// <summary>
        /// A positive integer representing the amount to subtract from an invoice total.
        /// </summary>
        [JsonProperty("amount_off")]
        public long? AmountOff { get; set; }
    }
}
