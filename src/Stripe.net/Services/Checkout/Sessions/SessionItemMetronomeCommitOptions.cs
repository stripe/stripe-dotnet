// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemMetronomeCommitOptions : INestedOptions
    {
        /// <summary>
        /// The list of commits to create for this Metronome contract.
        /// </summary>
        [JsonProperty("commits")]
        [STJS.JsonPropertyName("commits")]
        public List<SessionItemMetronomeCommitCommitOptions> Commits { get; set; }

        /// <summary>
        /// The Metronome contract ID to associate with this checkout item.
        /// </summary>
        [JsonProperty("metronome_contract")]
        [STJS.JsonPropertyName("metronome_contract")]
        public string MetronomeContract { get; set; }

        /// <summary>
        /// The currency and tax behavior configuration for this commit purchase.
        /// </summary>
        [JsonProperty("price_configuration")]
        [STJS.JsonPropertyName("price_configuration")]
        public SessionItemMetronomeCommitPriceConfigurationOptions PriceConfiguration { get; set; }
    }
}
