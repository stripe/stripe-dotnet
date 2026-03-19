// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountPersonScriptNames : StripeEntity<AccountPersonScriptNames>
    {
        /// <summary>
        /// Persons name in kana script.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AccountPersonScriptNamesKana Kana { get; set; }

        /// <summary>
        /// Persons name in kanji script.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AccountPersonScriptNamesKanji Kanji { get; set; }
    }
}
