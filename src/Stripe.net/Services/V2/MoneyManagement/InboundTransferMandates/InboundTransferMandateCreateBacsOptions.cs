// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferMandateCreateBacsOptions : INestedOptions
    {
        /// <summary>
        /// Optional prefix for the generated mandate reference (max 10 chars).
        /// </summary>
        [JsonProperty("reference_prefix")]
        [STJS.JsonPropertyName("reference_prefix")]
        public string ReferencePrefix { get; set; }
    }
}
