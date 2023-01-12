// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteLineActionAddDiscountDiscountEnd : StripeEntity<QuoteLineActionAddDiscountDiscountEnd>
    {
        /// <summary>
        /// The discount end type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
