// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateCardModifyRatesOptions : BaseOptions
    {
        /// <summary>
        /// The list of RateCard rates to create or update. Maximum of 100 rates.
        /// </summary>
        [JsonProperty("rates_to_create")]
        [STJS.JsonPropertyName("rates_to_create")]
        public List<RateCardModifyRatesRatesToCreateOptions> RatesToCreate { get; set; }

        /// <summary>
        /// The list of RateCard rates to delete. Maximum of 100 rates.
        /// </summary>
        [JsonProperty("rates_to_delete")]
        [STJS.JsonPropertyName("rates_to_delete")]
        public List<RateCardModifyRatesRatesToDeleteOptions> RatesToDelete { get; set; }
    }
}
