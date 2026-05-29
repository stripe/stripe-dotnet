// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractOneTimeFeeBillScheduleBillAt : StripeEntity<ContractOneTimeFeeBillScheduleBillAt>
    {
        /// <summary>
        /// The datetime at which the entry will be billed. Set when <c>type</c> is <c>datetime</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The type of the bill_at.
        /// One of: <c>contract_start</c>, or <c>datetime</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
