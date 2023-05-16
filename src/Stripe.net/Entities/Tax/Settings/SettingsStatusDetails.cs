// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsStatusDetails : StripeEntity<SettingsStatusDetails>
    {
        [JsonProperty("active")]
        public SettingsStatusDetailsActive Active { get; set; }

        [JsonProperty("pending")]
        public SettingsStatusDetailsPending Pending { get; set; }
    }
}
