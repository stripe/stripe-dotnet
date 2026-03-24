// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SettingsStatusDetails : StripeEntity<SettingsStatusDetails>
    {
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public SettingsStatusDetailsActive Active { get; set; }

        [JsonProperty("pending")]
        [STJS.JsonPropertyName("pending")]
        public SettingsStatusDetailsPending Pending { get; set; }
    }
}
