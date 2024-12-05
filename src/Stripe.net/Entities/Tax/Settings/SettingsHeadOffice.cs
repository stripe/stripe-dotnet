// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsHeadOffice : StripeEntity<SettingsHeadOffice>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
