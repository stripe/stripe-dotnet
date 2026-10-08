// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsCapitalOptions : INestedOptions, IHasSetTracking
    {
        private List<string> excludedPayoutDestinations;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The payout destinations excluded from Capital financing payouts.
        /// </summary>
        [JsonProperty("excluded_payout_destinations", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("excluded_payout_destinations")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> ExcludedPayoutDestinations
        {
            get => this.excludedPayoutDestinations;
            set
            {
                this.excludedPayoutDestinations = value;
                this.SetTracker.Track();
            }
        }

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

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
