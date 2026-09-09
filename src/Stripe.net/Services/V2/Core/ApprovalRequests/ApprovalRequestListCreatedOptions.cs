// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApprovalRequestListCreatedOptions : INestedOptions
    {
        /// <summary>
        /// Filter for objects created after the specified timestamp. Must be an RFC 3339 date &amp;
        /// time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("gt")]
        [STJS.JsonPropertyName("gt")]
        public DateTime? Gt { get; set; }

        /// <summary>
        /// Filter for objects created on or after the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public DateTime? Gte { get; set; }

        /// <summary>
        /// Filter for objects created before the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("lt")]
        [STJS.JsonPropertyName("lt")]
        public DateTime? Lt { get; set; }

        /// <summary>
        /// Filter for objects created on or before the specified timestamp. Must be an RFC 3339
        /// date &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public DateTime? Lte { get; set; }
    }
}
