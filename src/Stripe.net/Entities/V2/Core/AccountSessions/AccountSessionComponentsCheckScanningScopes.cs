// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsCheckScanningScopes : StripeEntity<AccountSessionComponentsCheckScanningScopes>
    {
        /// <summary>
        /// Whether to allow creating US paper checks on the application.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_us_paper_check_on_application")]
        [STJS.JsonPropertyName("create_us_paper_check_on_application")]
        public string CreateUsPaperCheckOnApplication { get; set; }
    }
}
