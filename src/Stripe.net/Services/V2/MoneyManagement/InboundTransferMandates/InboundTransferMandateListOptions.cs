// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferMandateListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by v2 credential.
        /// </summary>
        [JsonProperty("credential")]
        [STJS.JsonPropertyName("credential")]
        public string Credential { get; set; }

        /// <summary>
        /// Filter by mandate status.
        /// One of: <c>active</c>, <c>canceled</c>, <c>expired</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Filter by mandate scheme type.
        /// One of: <c>au_becs</c>, <c>bacs</c>, <c>nz_becs</c>, or <c>sepa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
