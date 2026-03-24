// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityIndividualScriptAddresses : StripeEntity<AccountIdentityIndividualScriptAddresses>
    {
        /// <summary>
        /// Kana Address.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AccountIdentityIndividualScriptAddressesKana Kana { get; set; }

        /// <summary>
        /// Kanji Address.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AccountIdentityIndividualScriptAddressesKanji Kanji { get; set; }
    }
}
