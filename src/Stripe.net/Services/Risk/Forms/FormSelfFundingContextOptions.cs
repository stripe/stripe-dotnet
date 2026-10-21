// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormSelfFundingContextOptions : INestedOptions
    {
        /// <summary>
        /// The connected account's source of wealth.
        /// </summary>
        [JsonProperty("source_of_wealth")]
        [STJS.JsonPropertyName("source_of_wealth")]
        public FormSelfFundingContextSourceOfWealthOptions SourceOfWealth { get; set; }
    }
}
