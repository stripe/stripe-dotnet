// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserAccessRisk : StripeEntity<ActivityLogDetailsUserAccessRisk>
    {
        /// <summary>
        /// Risk signals for the user access action.
        /// </summary>
        [JsonProperty("signals")]
        [STJS.JsonPropertyName("signals")]
        public List<ActivityLogDetailsUserAccessRiskSignal> Signals { get; set; }
    }
}
