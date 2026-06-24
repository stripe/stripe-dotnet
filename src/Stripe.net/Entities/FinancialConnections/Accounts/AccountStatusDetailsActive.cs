// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountStatusDetailsActive : StripeEntity<AccountStatusDetailsActive>
    {
        /// <summary>
        /// The action (if any) to proactively relink the Account.
        /// One of: <c>none</c>, or <c>relink_required</c>.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// The underlying cause of the Account becoming inactive.
        /// One of: <c>access_expired</c>, <c>institution_requirement</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("cause")]
        [STJS.JsonPropertyName("cause")]
        public string Cause { get; set; }

        /// <summary>
        /// When the Account is expected to become inactive, if applicable.
        /// </summary>
        [JsonProperty("expected_deactivation_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expected_deactivation_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpectedDeactivationDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
