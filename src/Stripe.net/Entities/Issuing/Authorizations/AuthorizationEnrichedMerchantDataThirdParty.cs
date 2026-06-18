// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantDataThirdParty : StripeEntity<AuthorizationEnrichedMerchantDataThirdParty>
    {
        [JsonProperty("data_sources")]
        [STJS.JsonPropertyName("data_sources")]
        public List<string> DataSources { get; set; }

        /// <summary>
        /// Image link to the third party's logo.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Name of the third party.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// If <c>spade</c> is a data source, this hash contains details provided by Spade.
        /// </summary>
        [JsonProperty("spade")]
        [STJS.JsonPropertyName("spade")]
        public AuthorizationEnrichedMerchantDataThirdPartySpade Spade { get; set; }

        /// <summary>
        /// Category of the third party.
        /// One of: <c>buy_now_pay_later</c>, <c>delivery_service</c>, <c>marketplace</c>,
        /// <c>other</c>, <c>payment_processor</c>, or <c>platform</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
