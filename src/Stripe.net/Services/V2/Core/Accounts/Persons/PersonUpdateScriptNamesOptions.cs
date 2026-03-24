// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonUpdateScriptNamesOptions : INestedOptions
    {
        /// <summary>
        /// Persons name in kana script.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public PersonUpdateScriptNamesKanaOptions Kana { get; set; }

        /// <summary>
        /// Persons name in kanji script.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public PersonUpdateScriptNamesKanjiOptions Kanji { get; set; }
    }
}
