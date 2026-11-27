// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Additional information explaining the dispute. Must contain non-whitespace text and be
        /// no longer than 5000 characters.
        /// </summary>
        [JsonProperty("explanation")]
        [STJS.JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The FinancialAccount holder's reason for disputing the money movement.
        /// One of: <c>authorization_revoked</c>, <c>duplicate</c>, <c>incorrect_amount</c>,
        /// <c>incorrect_date</c>, <c>other</c>, or <c>unauthorized</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The money movement being disputed.
        /// </summary>
        [JsonProperty("target")]
        [STJS.JsonPropertyName("target")]
        public DisputeCreateTargetOptions Target { get; set; }
    }
}
