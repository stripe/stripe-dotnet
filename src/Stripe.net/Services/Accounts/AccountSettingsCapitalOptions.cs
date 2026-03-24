// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsCapitalOptions : INestedOptions
    {
        /// <summary>
        /// Per-currency mapping of user-selected destination accounts used to pay out loans.
        /// </summary>
        [JsonProperty("payout_destination")]
        [STJS.JsonPropertyName("payout_destination")]
        public Dictionary<string, string> PayoutDestination { get; set; }

        /// <summary>
        /// Per-currency mapping of all destination accounts eligible to receive Capital financing
        /// payouts.
        /// </summary>
        [JsonProperty("payout_destination_selector")]
        [STJS.JsonPropertyName("payout_destination_selector")]
        public Dictionary<string, List<string>> PayoutDestinationSelector { get; set; }
    }
}
