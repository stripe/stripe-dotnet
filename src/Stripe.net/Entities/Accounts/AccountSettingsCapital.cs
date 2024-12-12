// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsCapital : StripeEntity<AccountSettingsCapital>
    {
        /// <summary>
        /// Per-currency mapping of user-selected destination accounts used to pay out loans.
        /// </summary>
        [JsonProperty("payout_destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_destination")]
#endif
        public Dictionary<string, string> PayoutDestination { get; set; }

        /// <summary>
        /// Per-currency mapping of all destination accounts eligible to receive loan payouts.
        /// </summary>
        [JsonProperty("payout_destination_selector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_destination_selector")]
#endif
        public Dictionary<string, List<string>> PayoutDestinationSelector { get; set; }
    }
}
