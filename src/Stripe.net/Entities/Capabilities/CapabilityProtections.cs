// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CapabilityProtections : StripeEntity<CapabilityProtections>
    {
        [JsonProperty("psp_migration")]
        [STJS.JsonPropertyName("psp_migration")]
        public CapabilityProtectionsPspMigration PspMigration { get; set; }
    }
}
