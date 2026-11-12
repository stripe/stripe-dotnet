// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsRadar : StripeEntity<ActivityLogDetailsRadar>
    {
        /// <summary>
        /// Risk preference after a preference switch carried by a protection-toggle action.
        /// One of: <c>balanced</c>, <c>custom</c>, <c>high_growth</c>, or <c>low_risk</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("new_risk_preference")]
        [STJS.JsonPropertyName("new_risk_preference")]
        public string NewRiskPreference { get; set; }

        /// <summary>
        /// Rules after the change. Set for add, update, enable, and disable actions; absent for
        /// remove actions.
        /// </summary>
        [JsonProperty("new_rules")]
        [STJS.JsonPropertyName("new_rules")]
        public List<ActivityLogDetailsRadarNewRule> NewRules { get; set; }

        /// <summary>
        /// Risk preference before a preference switch carried by a protection-toggle action.
        /// One of: <c>balanced</c>, <c>custom</c>, <c>high_growth</c>, or <c>low_risk</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("old_risk_preference")]
        [STJS.JsonPropertyName("old_risk_preference")]
        public string OldRiskPreference { get; set; }

        /// <summary>
        /// Rules before the change. Set for update, removal, enable, and disable actions; absent
        /// for add actions.
        /// </summary>
        [JsonProperty("old_rules")]
        [STJS.JsonPropertyName("old_rules")]
        public List<ActivityLogDetailsRadarOldRule> OldRules { get; set; }
    }
}
