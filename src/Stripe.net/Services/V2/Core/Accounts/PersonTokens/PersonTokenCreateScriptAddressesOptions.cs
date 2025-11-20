// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonTokenCreateScriptAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Kana Address.
        /// </summary>
        [JsonProperty("kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
#endif
        public AddressJapanOptions Kana { get; set; }

        /// <summary>
        /// Kanji Address.
        /// </summary>
        [JsonProperty("kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
#endif
        public AddressJapanOptions Kanji { get; set; }
    }
}
