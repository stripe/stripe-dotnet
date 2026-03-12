// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsCheckScanningFeaturesOptions : INestedOptions
    {
        [JsonProperty("create_us_paper_check_on_application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("create_us_paper_check_on_application")]
#endif
        public bool? CreateUsPaperCheckOnApplication { get; set; }
    }
}
