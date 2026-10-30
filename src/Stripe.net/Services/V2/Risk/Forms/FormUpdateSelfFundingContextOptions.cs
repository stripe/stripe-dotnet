// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUpdateSelfFundingContextOptions : INestedOptions
    {
        /// <summary>
        /// The connected account's source of wealth.
        /// </summary>
        [JsonProperty("source_of_wealth")]
        [STJS.JsonPropertyName("source_of_wealth")]
        public FormUpdateSelfFundingContextSourceOfWealthOptions SourceOfWealth { get; set; }
    }
}
