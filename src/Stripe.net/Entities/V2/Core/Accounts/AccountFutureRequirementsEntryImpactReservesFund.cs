// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsEntryImpactReservesFund : StripeEntity<AccountFutureRequirementsEntryImpactReservesFund>
    {
        /// <summary>
        /// Details about when funds will be reserved.
        /// </summary>
        [JsonProperty("deadline")]
        [STJS.JsonPropertyName("deadline")]
        public AccountFutureRequirementsEntryImpactReservesFundDeadline Deadline { get; set; }

        /// <summary>
        /// The balance destination for funds reserved as a result of this requirement.
        /// One of: <c>other</c>, <c>risk_reserved</c>, or <c>settlement_reserved</c>.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// The v1 ReservePlan created as a result of this requirement. Null until the plan is
        /// available. Not expandable.
        /// </summary>
        [JsonProperty("reserve_plan")]
        [STJS.JsonPropertyName("reserve_plan")]
        public string ReservePlan { get; set; }
    }
}
