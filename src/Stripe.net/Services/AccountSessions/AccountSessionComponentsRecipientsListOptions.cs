// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsRecipientsListOptions : INestedOptions
    {
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public AccountSessionComponentsRecipientsListFeaturesOptions Features { get; set; }
    }
}
