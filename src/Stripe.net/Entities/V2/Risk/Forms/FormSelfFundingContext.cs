// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormSelfFundingContext : StripeEntity<FormSelfFundingContext>
    {
        /// <summary>
        /// The connected account's source of wealth.
        /// </summary>
        [JsonProperty("source_of_wealth")]
        [STJS.JsonPropertyName("source_of_wealth")]
        public FormSelfFundingContextSourceOfWealth SourceOfWealth { get; set; }
    }
}
