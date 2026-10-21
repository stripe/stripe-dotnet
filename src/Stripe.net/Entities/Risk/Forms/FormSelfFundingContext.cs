// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormSelfFundingContext : StripeEntity<FormSelfFundingContext>
    {
        [JsonProperty("source_of_wealth")]
        [STJS.JsonPropertyName("source_of_wealth")]
        public FormSelfFundingContextSourceOfWealth SourceOfWealth { get; set; }
    }
}
