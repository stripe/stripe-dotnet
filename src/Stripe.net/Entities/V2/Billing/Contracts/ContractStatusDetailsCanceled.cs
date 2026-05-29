// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractStatusDetailsCanceled : StripeEntity<ContractStatusDetailsCanceled>
    {
        /// <summary>
        /// The timestamp when the contract was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
