// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderSpendingControlsSpendingLimit : StripeEntity<CardholderSpendingControlsSpendingLimit>
    {
        /// <summary>
        /// Maximum amount allowed to spend per interval. This amount is in the card's currency and
        /// in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest currency
        /// unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Array of strings containing <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-merchant_data-category">categories</a>
        /// this limit applies to. Omitting this field will apply the limit to all categories.
        /// </summary>
        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Interval (or event) to which the amount applies.
        /// One of: <c>all_time</c>, <c>daily</c>, <c>monthly</c>, <c>per_authorization</c>,
        /// <c>weekly</c>, or <c>yearly</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }
    }
}
