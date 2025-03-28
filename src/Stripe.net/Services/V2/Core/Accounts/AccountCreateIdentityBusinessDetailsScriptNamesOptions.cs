// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityBusinessDetailsScriptNamesOptions : INestedOptions
    {
        /// <summary>
        /// Kana name.
        /// </summary>
        [JsonProperty("kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
#endif
        public AccountCreateIdentityBusinessDetailsScriptNamesKanaOptions Kana { get; set; }

        /// <summary>
        /// Kanji name.
        /// </summary>
        [JsonProperty("kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
#endif
        public AccountCreateIdentityBusinessDetailsScriptNamesKanjiOptions Kanji { get; set; }
    }
}
