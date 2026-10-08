// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferMandateCreateAuBecsOptions : INestedOptions
    {
        /// <summary>
        /// Optional prefix for the generated 18-character lodgement reference. The prefix is
        /// normalized to uppercase and must be empty or contain 1-10 letters, digits, or
        /// underscores.
        /// </summary>
        [JsonProperty("lodgement_reference_prefix")]
        [STJS.JsonPropertyName("lodgement_reference_prefix")]
        public string LodgementReferencePrefix { get; set; }
    }
}
