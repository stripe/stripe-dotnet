// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CouponCurrencyOptionsOptions : INestedOptions
    {
        /// <summary>
        /// A positive integer representing the amount to subtract from an invoice total.
        /// </summary>
        [JsonProperty("amount_off")]
        [STJS.JsonPropertyName("amount_off")]
        public long? AmountOff { get; set; }
    }
}
