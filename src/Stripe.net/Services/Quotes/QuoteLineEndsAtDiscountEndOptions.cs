// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteLineEndsAtDiscountEndOptions : INestedOptions
    {
        /// <summary>
        /// The ID of a specific discount.
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }
    }
}
