// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountSettingsCapital : StripeEntity<AccountSettingsCapital>
    {
        /// <summary>
        /// Per-currency mapping of user-selected destination accounts used to pay out loans.
        /// </summary>
        [JsonProperty("payout_destination")]
        public Dictionary<string, string> PayoutDestination { get; set; }

        /// <summary>
        /// Per-currency mapping of all destination accounts eligible to receive loan payouts.
        /// </summary>
        [JsonProperty("payout_destination_selector")]
        public Dictionary<string, List<string>> PayoutDestinationSelector { get; set; }
    }
}
