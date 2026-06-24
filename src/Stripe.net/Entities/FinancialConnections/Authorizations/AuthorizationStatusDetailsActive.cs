// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationStatusDetailsActive : StripeEntity<AuthorizationStatusDetailsActive>
    {
        /// <summary>
        /// The action (if any) to proactively relink the Authorization.
        /// One of: <c>none</c>, or <c>relink_required</c>.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// When the Authorization is expected to become inactive, if applicable.
        /// </summary>
        [JsonProperty("expected_deactivation_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expected_deactivation_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpectedDeactivationDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
