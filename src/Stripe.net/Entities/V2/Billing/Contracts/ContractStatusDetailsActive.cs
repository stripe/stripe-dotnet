// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractStatusDetailsActive : StripeEntity<ContractStatusDetailsActive>
    {
        /// <summary>
        /// The timestamp when the contract was activated.
        /// </summary>
        [JsonProperty("activated_at")]
        [STJS.JsonPropertyName("activated_at")]
        public DateTime ActivatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
