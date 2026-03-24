// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsCheckScanningFeaturesOptions : INestedOptions
    {
        [JsonProperty("create_us_paper_check_on_application")]
        [STJS.JsonPropertyName("create_us_paper_check_on_application")]
        public bool? CreateUsPaperCheckOnApplication { get; set; }
    }
}
