// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AdjustmentListCreatedOptions : INestedOptions
    {
        /// <summary>
        /// Filter for Adjustments created after the specified timestamp. The timestamp must be in
        /// RFC 3339 format, for example <c>2022-09-18T13:22:00Z</c>.
        /// </summary>
        [JsonProperty("gt")]
        [STJS.JsonPropertyName("gt")]
        public DateTime? Gt { get; set; }

        /// <summary>
        /// Filter for Adjustments created on or after the specified timestamp. The timestamp must
        /// be in RFC 3339 format, for example <c>2022-09-18T13:22:00Z</c>.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public DateTime? Gte { get; set; }

        /// <summary>
        /// Filter for Adjustments created before the specified timestamp. The timestamp must be in
        /// RFC 3339 format, for example <c>2022-09-18T13:22:00Z</c>.
        /// </summary>
        [JsonProperty("lt")]
        [STJS.JsonPropertyName("lt")]
        public DateTime? Lt { get; set; }

        /// <summary>
        /// Filter for Adjustments created on or before the specified timestamp. The timestamp must
        /// be in RFC 3339 format, for example <c>2022-09-18T13:22:00Z</c>.
        /// </summary>
        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public DateTime? Lte { get; set; }
    }
}
