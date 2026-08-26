// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountActivityAccountDetailsData : StripeEntity<AccountActivityAccountDetailsData>
    {
        /// <summary>
        /// Default account settings.
        /// </summary>
        [JsonProperty("defaults")]
        [STJS.JsonPropertyName("defaults")]
        public AccountActivityAccountDetailsDataDefaults Defaults { get; set; }
    }
}
