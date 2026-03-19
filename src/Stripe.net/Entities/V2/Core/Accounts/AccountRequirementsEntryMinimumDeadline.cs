// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRequirementsEntryMinimumDeadline : StripeEntity<AccountRequirementsEntryMinimumDeadline>
    {
        /// <summary>
        /// The current status of the requirement's impact.
        /// One of: <c>currently_due</c>, <c>eventually_due</c>, or <c>past_due</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
