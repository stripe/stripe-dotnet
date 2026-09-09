// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractOneTimeFees : StripeEntity<ContractOneTimeFees>
    {
        /// <summary>
        /// The one-time fees for this page.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<ContractOneTimeFeesData> Data { get; set; }
    }
}
