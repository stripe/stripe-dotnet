// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityIndividualScriptAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Kana Address.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AddressJapanOptions Kana { get; set; }

        /// <summary>
        /// Kanji Address.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AddressJapanOptions Kanji { get; set; }
    }
}
