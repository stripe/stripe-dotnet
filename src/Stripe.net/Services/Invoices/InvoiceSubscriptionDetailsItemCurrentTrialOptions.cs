// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceSubscriptionDetailsItemCurrentTrialOptions : INestedOptions
    {
        /// <summary>
        /// Unix timestamp representing the end of the trial offer period. Required when the trial
        /// offer has <c>duration.type=timestamp</c>. Cannot be specified when
        /// <c>duration.type=relative</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// The ID of the trial offer to apply to the subscription item.
        /// </summary>
        [JsonProperty("trial_offer")]
        [STJS.JsonPropertyName("trial_offer")]
        public string TrialOffer { get; set; }
    }
}
