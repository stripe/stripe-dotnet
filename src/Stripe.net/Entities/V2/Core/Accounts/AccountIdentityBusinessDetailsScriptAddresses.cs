// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityBusinessDetailsScriptAddresses : StripeEntity<AccountIdentityBusinessDetailsScriptAddresses>
    {
        /// <summary>
        /// Kana Address.
        /// </summary>
        [JsonProperty("kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
#endif
        public AccountIdentityBusinessDetailsScriptAddressesKana Kana { get; set; }

        /// <summary>
        /// Kanji Address.
        /// </summary>
        [JsonProperty("kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
#endif
        public AccountIdentityBusinessDetailsScriptAddressesKanji Kanji { get; set; }
    }
}
