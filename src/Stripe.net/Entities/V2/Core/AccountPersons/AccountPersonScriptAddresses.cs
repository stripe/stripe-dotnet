// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountPersonScriptAddresses : StripeEntity<AccountPersonScriptAddresses>
    {
        /// <summary>
        /// Kana Address.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AccountPersonScriptAddressesKana Kana { get; set; }

        /// <summary>
        /// Kanji Address.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AccountPersonScriptAddressesKanji Kanji { get; set; }
    }
}
