// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountActivityAccountDetailsDataDefaults : StripeEntity<AccountActivityAccountDetailsDataDefaults>
    {
        /// <summary>
        /// Account profile data.
        /// </summary>
        [JsonProperty("profile")]
        [STJS.JsonPropertyName("profile")]
        public AccountActivityAccountDetailsDataDefaultsProfile Profile { get; set; }
    }
}
