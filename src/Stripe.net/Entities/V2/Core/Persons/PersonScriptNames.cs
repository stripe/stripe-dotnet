// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonScriptNames : StripeEntity<PersonScriptNames>
    {
        /// <summary>
        /// Persons name in kana script.
        /// </summary>
        [JsonProperty("kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
#endif
        public PersonScriptNamesKana Kana { get; set; }

        /// <summary>
        /// Persons name in kanji script.
        /// </summary>
        [JsonProperty("kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
#endif
        public PersonScriptNamesKanji Kanji { get; set; }
    }
}
