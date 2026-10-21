// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommit : StripeEntity<SessionItemMetronomeCommit>
    {
        /// <summary>
        /// The list of commits for this Metronome contract.
        /// </summary>
        [JsonProperty("commits")]
        [STJS.JsonPropertyName("commits")]
        public List<SessionItemMetronomeCommitCommit> Commits { get; set; }

        /// <summary>
        /// The Metronome contract ID associated with this checkout item.
        /// </summary>
        [JsonProperty("metronome_contract")]
        [STJS.JsonPropertyName("metronome_contract")]
        public string MetronomeContract { get; set; }

        /// <summary>
        /// The Metronome customer ID associated with this checkout item, resolved during
        /// validation.
        /// </summary>
        [JsonProperty("metronome_customer")]
        [STJS.JsonPropertyName("metronome_customer")]
        public string MetronomeCustomer { get; set; }

        [JsonProperty("price_configuration")]
        [STJS.JsonPropertyName("price_configuration")]
        public SessionItemMetronomeCommitPriceConfiguration PriceConfiguration { get; set; }
    }
}
