// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsSummary : StripeEntity<AccountFutureRequirementsSummary>
    {
        /// <summary>
        /// The soonest date and time a requirement on the Account will become <c>past due</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("minimum_deadline")]
        [STJS.JsonPropertyName("minimum_deadline")]
        public AccountFutureRequirementsSummaryMinimumDeadline MinimumDeadline { get; set; }
    }
}
