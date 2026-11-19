// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Contracts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TermListContractTermsOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter terms by type.
        /// One of: <c>pricing_override</c>, <c>recurring_price</c>, or <c>scheduled_fee</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
