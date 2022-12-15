// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteLineActionAddDiscountDiscountEndOptions : INestedOptions
    {
        /// <summary>
        /// The type of calculation made to determine when the discount ends.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
