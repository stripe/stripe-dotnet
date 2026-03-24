// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsPaymentDisputesFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether connected accounts can manage destination charges that are created on behalf of
        /// them. This is <c>false</c> by default.
        /// </summary>
        [JsonProperty("destination_on_behalf_of_charge_management")]
        [STJS.JsonPropertyName("destination_on_behalf_of_charge_management")]
        public bool? DestinationOnBehalfOfChargeManagement { get; set; }

        /// <summary>
        /// Whether responding to disputes is enabled, including submitting evidence and accepting
        /// disputes. This is <c>true</c> by default.
        /// </summary>
        [JsonProperty("dispute_management")]
        [STJS.JsonPropertyName("dispute_management")]
        public bool? DisputeManagement { get; set; }

        /// <summary>
        /// Whether sending refunds is enabled. This is <c>true</c> by default.
        /// </summary>
        [JsonProperty("refund_management")]
        [STJS.JsonPropertyName("refund_management")]
        public bool? RefundManagement { get; set; }
    }
}
