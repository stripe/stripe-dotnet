// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CouponCurrencyOptionsOptions : INestedOptions
    {
        /// <summary>
        /// A positive integer representing the amount to subtract from an invoice total.
        /// </summary>
        [JsonProperty("amount_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_off")]
#endif
        public long? AmountOff { get; set; }
    }
}
