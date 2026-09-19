// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsCapital : StripeEntity<AccountSettingsCapital>
    {
        /// <summary>
        /// The payout destinations allowed for Capital financing payouts.
        /// </summary>
        [JsonProperty("allowed_payout_destinations")]
        [STJS.JsonPropertyName("allowed_payout_destinations")]
        public List<string> AllowedPayoutDestinations { get; set; }

        /// <summary>
        /// The payout destinations excluded from Capital financing payouts.
        /// </summary>
        [JsonProperty("excluded_payout_destinations")]
        [STJS.JsonPropertyName("excluded_payout_destinations")]
        public List<string> ExcludedPayoutDestinations { get; set; }
    }
}
