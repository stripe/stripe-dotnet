// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityBusinessDetailsScriptAddresses : StripeEntity<AccountIdentityBusinessDetailsScriptAddresses>
    {
        /// <summary>
        /// Kana Address.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AccountIdentityBusinessDetailsScriptAddressesKana Kana { get; set; }

        /// <summary>
        /// Kanji Address.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AccountIdentityBusinessDetailsScriptAddressesKanji Kanji { get; set; }
    }
}
