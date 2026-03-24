// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityBusinessDetailsScriptNamesOptions : INestedOptions
    {
        /// <summary>
        /// Kana name.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AccountTokenCreateIdentityBusinessDetailsScriptNamesKanaOptions Kana { get; set; }

        /// <summary>
        /// Kanji name.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AccountTokenCreateIdentityBusinessDetailsScriptNamesKanjiOptions Kanji { get; set; }
    }
}
